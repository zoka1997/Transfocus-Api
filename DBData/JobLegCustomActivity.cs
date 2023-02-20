using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegCustomActivity
    {
        public JobLegCustomActivity()
        {
            JobLegCustomActivityHistories = new HashSet<JobLegCustomActivityHistory>();
        }

        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public Guid CustomActivityId { get; set; }
        public DateTime DeviceTimestamp { get; set; }
        public string CustomActivityValue { get; set; } = null!;

        public virtual CustomActivity CustomActivity { get; set; } = null!;
        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual ICollection<JobLegCustomActivityHistory> JobLegCustomActivityHistories { get; set; }
    }
}
