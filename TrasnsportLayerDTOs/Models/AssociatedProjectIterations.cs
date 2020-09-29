using System;
using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public partial class AssociatedProjectIterations
    {
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int IterationId { get; set; }
        public int? ActiveIteration { get; set; }

        public virtual WorkItemIterations Iteration { get; set; }
        public virtual Projects Project { get; set; }
    }
}
