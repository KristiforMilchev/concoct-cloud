using System.Collections.Generic;
using TransportLayer.Models;

namespace  TransportLayer.Models
{
    public class IncomingExistingProjectMembers
    {
        public int ProjectId { get; set; }
        public List<OutgoingUserAccounts> Accounts { get; set; }
    }
}