using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class GridStateProfile
    {
        public GridStateProfile()
        {
            GridStateColumns = new HashSet<GridStateColumn>();
            GridStateDefaults = new HashSet<GridStateDefault>();
            GridStateProfilePermissions = new HashSet<GridStateProfilePermission>();
        }

        public Guid Id { get; set; }
        public string GridId { get; set; } = null!;
        public string? ProfileName { get; set; }
        public Guid? CompanyId { get; set; }
        public string? UserId { get; set; }
        public bool IsDefault { get; set; }
        public DateTime Timestamp { get; set; }
        public int? DateFilterProfileId { get; set; }
        public int? PageSize { get; set; }

        public virtual Company? Company { get; set; }
        public virtual WebPanelUser? User { get; set; }
        public virtual ICollection<GridStateColumn> GridStateColumns { get; set; }
        public virtual ICollection<GridStateDefault> GridStateDefaults { get; set; }
        public virtual ICollection<GridStateProfilePermission> GridStateProfilePermissions { get; set; }
    }
}
