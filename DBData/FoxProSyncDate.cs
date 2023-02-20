using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FoxProSyncDate
    {
        public string Id { get; set; } = null!;
        public Guid CompanyId { get; set; }
        public DateTime LastSync { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
