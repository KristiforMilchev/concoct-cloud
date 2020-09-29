using  TransportLayer.Models;

namespace TransportLayer.Models
{
    public class BindingWorkItemRelation
    {
        public BindingWorkItemDTO WorkItem { get; set; }
        public string RelationType { get; set; }
    }
}