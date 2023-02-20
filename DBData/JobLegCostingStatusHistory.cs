using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegCostingStatusHistory
    {
        public Guid Id { get; set; }
        public Guid? JobLegId { get; set; }
        public string CostingStatusId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public string? Description { get; set; }
        public DateTime? TimeStampUtc { get; set; }
        public Guid? ManifestId { get; set; }

        public virtual CostingStatus CostingStatus { get; set; } = null!;
        public virtual JobLeg? JobLeg { get; set; }
        public virtual Manifest? Manifest { get; set; }
    }
}
