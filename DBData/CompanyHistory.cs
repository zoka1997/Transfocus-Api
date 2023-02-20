using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CompanyHistory
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Description { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public DateTime? TimeStampUtc { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
