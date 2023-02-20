using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class UserGroup
    {
        public UserGroup()
        {
            GridStateProfilePermissions = new HashSet<GridStateProfilePermission>();
            SystemPermissions = new HashSet<SystemPermission>();
            WebPanelUsers = new HashSet<WebPanelUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedOn { get; set; }
        public Guid CompanyId { get; set; }
        public int UserTypeId { get; set; }
        public string? JobTotalsGrid { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual WebPanelUsersType UserType { get; set; } = null!;
        public virtual ICollection<GridStateProfilePermission> GridStateProfilePermissions { get; set; }
        public virtual ICollection<SystemPermission> SystemPermissions { get; set; }
        public virtual ICollection<WebPanelUser> WebPanelUsers { get; set; }
    }
}
