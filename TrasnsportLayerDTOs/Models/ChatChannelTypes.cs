using System;
using System.Collections.Generic;

namespace TransportLayer.Models
{
    public partial class ChatChannelTypes
    {
        public ChatChannelTypes()
        {
            ChatChannels = new HashSet<ChatChannels>();
        }

        public int Id { get; set; }
        public string TypeName { get; set; }

        public virtual ICollection<ChatChannels> ChatChannels { get; set; }
    }
}
