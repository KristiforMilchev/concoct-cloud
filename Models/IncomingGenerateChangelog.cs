using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class IncomingGenerateChangelog
    {
        public List<OutgoingWorkItemSimple> Items { get; set; }
        public string Chagelog { get; set; }
        public int ProjectId { get; set; }
    }
}