﻿using System.Collections.Generic;

namespace Rokono_Control.Models
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
