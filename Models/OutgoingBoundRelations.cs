using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class OutgoingBoundRelations
    {
        public string UmlData {get; set;}
        public List<BindingWorkItemRelation> WorkItems {get; set;}
    }
}