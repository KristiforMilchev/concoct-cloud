﻿using System;
using System.Collections.Generic;

namespace RCServerCli.Models
{
    public partial class AssociatedWorkItemFiles
    {
        public int Id { get; set; }
        public int? WorkItemId { get; set; }
        public int? FileId { get; set; }

        public virtual SystemFiles File { get; set; }
        public virtual WorkItem WorkItem { get; set; }
    }
}
