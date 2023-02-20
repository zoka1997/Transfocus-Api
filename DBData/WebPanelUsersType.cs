using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class WebPanelUsersType
    {
        public WebPanelUsersType()
        {
            SystemSectionUserTypes = new HashSet<SystemSectionUserType>();
            UserGroups = new HashSet<UserGroup>();
            WebPanelUsers = new HashSet<WebPanelUser>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<SystemSectionUserType> SystemSectionUserTypes { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<WebPanelUser> WebPanelUsers { get; set; }
    }
}
