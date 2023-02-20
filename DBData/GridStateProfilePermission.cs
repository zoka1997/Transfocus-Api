using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class GridStateProfilePermission
    {
        public Guid Id { get; set; }
        public string GridCode { get; set; } = null!;
        public Guid GridProfileId { get; set; }
        public int UserGroupId { get; set; }
        public bool IsDefault { get; set; }
        public int? Lvl { get; set; }

        public virtual GridStateProfile GridProfile { get; set; } = null!;
        public virtual UserGroup UserGroup { get; set; } = null!;
    }
}
