using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ManifestHistory
    {
        public Guid Id { get; set; }
        public Guid ManifestId { get; set; }
        public string ManifestStatusId { get; set; } = null!;
        public DateTime? DeviceTimestamp { get; set; }
        public DateTime Timestamp { get; set; }
        public string? UserId { get; set; }
        public string? Description { get; set; }
        public string? IpAddress { get; set; }
        public DateTime? TimestampUtc { get; set; }

        public virtual Manifest Manifest { get; set; } = null!;
        public virtual ManifestStatus ManifestStatus { get; set; } = null!;
        public virtual WebPanelUser? User { get; set; }
    }
}
