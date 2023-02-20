using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class MobileLog
    {
        public Guid Id { get; set; }
        public DateTime? DeviceTimestamp { get; set; }
        public string? Description { get; set; }
        public string? Users { get; set; }
        public Guid? Token { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? JobId { get; set; }
        public Guid? ManifestId { get; set; }
        public Guid? LegId { get; set; }
        public string? Type { get; set; }

        public virtual JobLeg? Leg { get; set; }
        public virtual Manifest? Manifest { get; set; }
    }
}
