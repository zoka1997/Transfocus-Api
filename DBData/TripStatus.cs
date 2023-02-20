using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class TripStatus
    {
        public TripStatus()
        {
            Companies = new HashSet<Company>();
            JobLegHistories = new HashSet<JobLegHistory>();
            JobLegs = new HashSet<JobLeg>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<JobLegHistory> JobLegHistories { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
    }
}
