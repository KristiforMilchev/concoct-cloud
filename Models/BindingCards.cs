namespace Rokono_Control.Models
{
    public class BindingCards
    {
        public int InnerId { get; set; }
        public string Assignee { get; set; }
        public int AssigneeId {get; set;}
        public string Id { get; set; }
        public string Priority { get; set; }
        public string Type { get; set; }
        public string Summary { get; set; }
        public string Status { get; set; }
        public string Tags { get; set; }
        public string AssgignedAccount { get; set; }
        public string Title { get; set; }
        public string Complete {get; set;}
        public string Remaining {get; set;}
        public string ClosedAt { get; set; }
        //   public List<RelatedItems> Children { get; set; }
    }
}