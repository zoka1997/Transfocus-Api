using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegStatusHistory
    {
        public Guid Id { get; set; }
        public string StatusName { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid? JobLegId { get; set; }
        public string? LegStatusId { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public DateTime? TimeStampUtc { get; set; }

        public virtual JobLeg? JobLeg { get; set; }
        public virtual LegStatus? LegStatus { get; set; }
    }
}
