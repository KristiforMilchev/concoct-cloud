namespace WWServer.Packets.ClientPackets
{
    using DbScaffold.Models;

    using Lidgren.Network;
    using StoriesUntoldDataLayer.DataContext;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using WWServer.Interpritators;

    class AuthenicationPackets
    {
        public static bool Authenicated(int connectionId)
        {
            try
            {
                return ClientController.Clients.FirstOrDefault(x => x.Id == connectionId).Authenicated;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception in authenication validator on packet communication inner exception {ex.InnerException}");
                return false;
            }

        }
        internal static void SendSalt(string result, string publicKey, int connectionId)
        {
            var cData = new List<object>
            {
                 ServerPackets.CCSalt,
                 result,
                 publicKey
            };
            ClientController.SendDataTo(connectionId, cData, NetDeliveryMethod.ReliableOrdered, 0);
        }
        internal static void SrpHandShakeValidateClientSide(string proof, int connectionId)
        {
            var cData = new List<object>
            {
                 ServerPackets.CSrptConfirmHandshake,
                 connectionId,
                 proof
            };
            ClientController.SendDataTo(connectionId, cData, NetDeliveryMethod.ReliableOrdered, 0);
        }

        internal static void CloseForClients(int connectionID)
        {

            var cData = new List<object>
            {
                 ServerPackets.SClosedConnectionForClient ,
                 connectionID
            };
            ClientController.SendDataAllBut(connectionID, cData, NetDeliveryMethod.ReliableOrdered, 0);

        }
        internal static void InitializeConnection(int id)
        {
            var cData = new List<object>
            {
                 ServerPackets.SInitializeConnection,
                 id,

            };
            ClientController.SendDataTo(id, cData, NetDeliveryMethod.ReliableOrdered, 0);
        }
        public static void SendInGame(int connectionId)
        {
            ClientController.Clients.FirstOrDefault(x => x.Id == connectionId).Authenicated = true;
            var cData = new List<object>
            {
                 ServerPackets.SIngame,
                 connectionId

            };
            ClientController.SendDataTo(connectionId, cData, NetDeliveryMethod.ReliableOrdered, 0);
            //  SendInWorld(connectionId);
        }

        internal static void SendErrorLogin(int connectionId)
        {
            var cData = new List<object>
            {
                 ServerPackets.SCRefused ,
                 connectionId
            };
            ClientController.SendDataTo(connectionId, cData, NetDeliveryMethod.ReliableOrdered, 0);
        }

        internal static void DisconnectPlayer(int playerId)
        {

            var cData = new List<object>
            {
                 ServerPackets.SDisconnect ,
                 playerId
            };
            ClientController.SendDataAllBut(playerId, cData, NetDeliveryMethod.ReliableOrdered, 0);
        }

        internal static void InstantiatePlayer(int connectionId)
        {
            var clientData = ClientController.Clients.FirstOrDefault(x => x.Id == connectionId);
            var characterData = DatabaseLayer.GetCharacterData(clientData.AccountId, clientData.LoggedInCharacterId);
            characterData = Converters.GetCharacterRecepie(characterData);

  

            ClientController.Clients.FirstOrDefault(x => x.Id == connectionId).ClientPosssition = clientData.ClientPosssition;

            characterData.AssociatedAccountCharacters = null;
            characterData.AssociatedCharacterCompletedQuests = null;
            characterData.AssociatedCharacterQuests = null;
            characterData.AssociatedEquippedCharacterItems = null;

            ClientController.SendInWorldLoadCharacters(connectionId, NetDeliveryMethod.ReliableOrdered, 0);
            ClientController.SendCharacterToClientsInZone(connectionId, NetDeliveryMethod.ReliableOrdered, 0);
        }

        public static void InstantiateInWorld(int connectionId, int zoneId)
        {

            ClientController.Clients.FirstOrDefault(x => x.Id == connectionId).Authenicated = true;
            var cData = new List<object>
            {
                 ServerPackets.SCSelected ,
                 connectionId ,
                 Seasons.Fall,
                 40,
                 60
            };
            var client = ClientController.Clients.FirstOrDefault(x => x.Id == connectionId).LoggedInCharacterId;
            ClientController.SendObjectDataTo(om, clientData, NetDeliveryMethod.ReliableOrdered, 0);

        }


        //internal static void InitializeNpcDialogs(List<List<AssociatedNpcConversations>> npcData, int connectionId)
        //{
        //    var cData = new List<object>
        //    {
        //         ServerPackets.SNpcDialogData ,
        //         connectionId ,
        //         SerializeConfig(npcData),
        //         "EP"
        //    };
        //    SendDataTo(connectionId, cData);
        //}

    }
}
