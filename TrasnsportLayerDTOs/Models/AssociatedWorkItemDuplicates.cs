using System;
using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public partial class AssociatedWorkItemDuplicates
    {
        public int Id { get; set; }
        public int? WorkItemId { get; set; }
        public int? WorkItemChildId { get; set; }

        public virtual WorkItem WorkItem { get; set; }
        public virtual WorkItem WorkItemChild { get; set; }
    }
}
