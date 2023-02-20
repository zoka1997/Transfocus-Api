using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegCustomActivityHistory
    {
        public Guid Id { get; set; }
        public Guid JobLegCustomActivityId { get; set; }
        public string OldValue { get; set; } = null!;
        public string NewValue { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string? Description { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public DateTime? TimeStampUtc { get; set; }

        public virtual JobLegCustomActivity JobLegCustomActivity { get; set; } = null!;
    }
}
