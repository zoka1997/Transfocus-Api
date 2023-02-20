using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class LegStatus
    {
        public LegStatus()
        {
            JobLegStatusHistories = new HashSet<JobLegStatusHistory>();
            JobLegs = new HashSet<JobLeg>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }

        public virtual ICollection<JobLegStatusHistory> JobLegStatusHistories { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
    }
}
