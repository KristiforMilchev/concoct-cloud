﻿using System;
using System.Collections.Generic;

namespace RCServerCli.Models
{
    public partial class AssociatedDocumentationCategoryPage
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public int? CategoryField { get; set; }
        public string Title { get; set; }

        public virtual DocumentationCategoryField CategoryFieldNavigation { get; set; }
    }
}
