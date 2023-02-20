using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SystemPermission
    {
        public Guid Id { get; set; }
        public int UserGroupId { get; set; }
        public Guid SystemSectionId { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedOn { get; set; }

        public virtual SystemSection SystemSection { get; set; } = null!;
        public virtual UserGroup UserGroup { get; set; } = null!;
    }
}
