using System.Collections.Generic;

namespace Rokono_Control.Models
{
    public class IncomingExistingProjectMembers
    {
        public int ProjectId { get; set; }
        public List<OutgoingUserAccounts> Accounts { get; set; }
    }
}