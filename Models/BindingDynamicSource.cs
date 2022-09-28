using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class BindingDynamicSource
    {
        public string QuestionId { get; set; }
        public string QuestionValue { get; set; }
        public string renderId { get; set; }
        public List<KeyValuePair> ComponentSource { get; set; }
    }
}