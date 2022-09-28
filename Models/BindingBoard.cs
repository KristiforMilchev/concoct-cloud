using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class BindingBoard
    {
        public int Id  { get; set; }
        public string Name { get; set; }
        public List<BindingCards> Cards { get; set; }
    }
}