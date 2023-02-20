using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SystemSection
    {
        public SystemSection()
        {
            SystemPermissions = new HashSet<SystemPermission>();
            SystemSectionUserTypes = new HashSet<SystemSectionUserType>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? SectionGroup { get; set; }
        public string? Code { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<SystemPermission> SystemPermissions { get; set; }
        public virtual ICollection<SystemSectionUserType> SystemSectionUserTypes { get; set; }
    }
}
