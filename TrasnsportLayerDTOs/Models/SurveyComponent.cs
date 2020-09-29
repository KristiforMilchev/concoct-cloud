using System;
using System.Collections.Generic;

namespace  TransportLayer.Models
{
    public partial class SurveyComponent
    {
        public SurveyComponent()
        {
            AssociatedPageSurveyComponents = new HashSet<AssociatedPageSurveyComponents>();
        }

        public int Id { get; set; }
        public string ComponentInternalName { get; set; }
        public string PlatformName { get; set; }

        public virtual ICollection<AssociatedPageSurveyComponents> AssociatedPageSurveyComponents { get; set; }
    }
}
