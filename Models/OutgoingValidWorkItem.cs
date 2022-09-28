using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class OutgoingValidWorkItem
    {
        public List<WorkItem> WorkItem { get; set; }
        public bool Valid { get; set; }
        public int WorkItemTypeId { get; set; }
        public int WorkItemId { get; set; }
        public string  RelationshipId { get; set; }
        public WorkItem Last { get; set; }
    }
}