using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class TimeSlot
    {
        public TimeSlot()
        {
            JobLegs = new HashSet<JobLeg>();
            Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public TimeSpan TimeFrom { get; set; }
        public TimeSpan TimeTo { get; set; }
        public Guid CompanyId { get; set; }
        public bool Active { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
