﻿using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public partial class WorkItemStates
    {
        public WorkItemStates()
        {
            WorkItem = new HashSet<WorkItem>();
        }

        public int Id { get; set; }
        public string StateName { get; set; }

        public virtual ICollection<WorkItem> WorkItem { get; set; }
    }
}
