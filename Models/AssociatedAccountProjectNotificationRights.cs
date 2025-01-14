﻿namespace Rokono_Control.Models
{
    public partial class AssociatedAccountProjectNotificationRights
    {
        public int Id { get; set; }
        public int? ProjectId { get; set; }
        public int? UserId { get; set; }
        public int? RightId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual NotificationRights Right { get; set; }
        public virtual UserAccounts User { get; set; }
    }
}
