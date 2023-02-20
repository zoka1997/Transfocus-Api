using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegHistory
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public string TripStatusId { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public DateTime DeviceTimestamp { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public string? Description { get; set; }
        public DateTime? TimeStampUtc { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual TripStatus TripStatus { get; set; } = null!;
    }
}
