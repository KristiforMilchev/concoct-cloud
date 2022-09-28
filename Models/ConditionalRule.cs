using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class ConditionalRule
    {
        public string condition { get; set; }
        public List<ObjectRule> Rules { get; set; }
    }
}