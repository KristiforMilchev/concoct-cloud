using System;
using System.Collections.Generic;

namespace TransportLayer.Models
{
    public partial class AssociatedWorkItemMessages
    {
        public int Id { get; set; }
        public int WorkItemId { get; set; }
        public int MessageId { get; set; }

        public virtual WorkItemMessage Message { get; set; }
        public virtual WorkItem WorkItem { get; set; }
    }
}
