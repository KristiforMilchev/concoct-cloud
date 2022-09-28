using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class IncomingEmailReportRequest
    {
        public int ProjectId { get; set; }
        public List<OutgoingWorkItem> Items {get; set;}
    }
}