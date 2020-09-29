using System;
using System.Collections.Generic;

namespace TransportLayer.Models
{
    public partial class WorkItemActivity
    {
        public WorkItemActivity()
        {
            WorkItem = new HashSet<WorkItem>();
        }

        public int Id { get; set; }
        public string ActivityName { get; set; }

        public virtual ICollection<WorkItem> WorkItem { get; set; }
    }
}
