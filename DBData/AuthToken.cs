using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AuthToken
    {
        public AuthToken()
        {
            DriverSignatures = new HashSet<DriverSignature>();
            Gpslogs = new HashSet<Gpslog>();
            RapidCheckLists = new HashSet<RapidCheckList>();
        }

        public Guid Token { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Active { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid UserId { get; set; }
        public Guid DeviceId { get; set; }
        public string? GcmregistrationId { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? BreakStartTime { get; set; }
        public DateTime? BreakEndTime { get; set; }
        public string? AppVersion { get; set; }
        public string? AndroidVersion { get; set; }

        public virtual MobileDevice Device { get; set; } = null!;
        public virtual User User { get; set; } = null!;
        public virtual FleetAsset? Vehicle { get; set; }
        public virtual ICollection<DriverSignature> DriverSignatures { get; set; }
        public virtual ICollection<Gpslog> Gpslogs { get; set; }
        public virtual ICollection<RapidCheckList> RapidCheckLists { get; set; }
    }
}
