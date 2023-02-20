using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ZonesMulti
    {
        public Guid Id { get; set; }
        public Guid ZoneId { get; set; }
        public Guid SuburbId { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime? Timestamp { get; set; }

        public virtual Zone Zone { get; set; } = null!;
    }
}
