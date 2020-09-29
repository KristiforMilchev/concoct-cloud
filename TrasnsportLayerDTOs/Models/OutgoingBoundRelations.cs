using System.Collections.Generic;
using TransportLayer.Models;

namespace TransportLayer.Models
{
    public class OutgoingBoundRelations
    {
        public string UmlData {get; set;}
        public List<BindingWorkItemRelation> WorkItems {get; set;}
    }
}