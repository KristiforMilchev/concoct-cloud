using System;
using System.Collections.Generic;

namespace TransportLayer.Models
{
    public partial class UserDashboardItemComponent
    {
        public UserDashboardItemComponent()
        {
            AssociatedUserDashboardItemComponent = new HashSet<AssociatedUserDashboardItemComponent>();
        }

        public int Id { get; set; }
        public string ComponentName { get; set; }
        public int? IsRow { get; set; }
        public int? ColumnNumber { get; set; }
        public string ComponentInternalName { get; set; }

        public virtual ICollection<AssociatedUserDashboardItemComponent> AssociatedUserDashboardItemComponent { get; set; }
    }
}
