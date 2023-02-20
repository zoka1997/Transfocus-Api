using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegActivity
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public Guid? ActivityId { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime DeviceTimestamp { get; set; }
        public Guid? CustomActivityId { get; set; }
        public string? CustomActivityValue { get; set; }

        public virtual Activity? Activity { get; set; }
        public virtual CustomActivity? CustomActivity { get; set; }
        public virtual JobLeg JobLeg { get; set; } = null!;
    }
}
