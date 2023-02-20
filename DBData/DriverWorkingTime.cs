using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class DriverWorkingTime
    {
        public Guid Id { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public DateTime? BreakStartTime { get; set; }
        public DateTime? BreakEndTime { get; set; }
        public Guid? ManifestId { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? AuthToken { get; set; }

        public virtual Manifest? Manifest { get; set; }
    }
}
