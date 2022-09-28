﻿using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public partial class WorkItemPriorities
    {
        public WorkItemPriorities()
        {
            WorkItem = new HashSet<WorkItem>();
        }

        public int Id { get; set; }
        public string PriorityName { get; set; }

        public virtual ICollection<WorkItem> WorkItem { get; set; }
    }
}
