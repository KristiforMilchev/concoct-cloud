namespace TransportLayer.Models
{
    using System.Collections.Generic;
    using  TransportLayer.Models;
    public class IncomingEmailReportRequest
    {
        public int ProjectId { get; set; }
        public List<OutgoingWorkItem> Items {get; set;}
    }
}