using System.Collections.Generic;

namespace TransportLayer.Models
{
    public class OutgoingWorkItemCollection
    {
        public List<WorkItem> NoParents { get; set; }
        public List<WorkItem> ContainingParent { get; set; }
    }
}