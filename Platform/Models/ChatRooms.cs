﻿using System;
using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public partial class ChatRooms
    {
        public ChatRooms()
        {
            ChatChannels = new HashSet<ChatChannels>();
        }

        public int Id { get; set; }
        public string RoomName { get; set; }
        public int? ProjectId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual ICollection<ChatChannels> ChatChannels { get; set; }
    }
}
