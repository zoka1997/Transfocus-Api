using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobTripStatus
    {
        public JobTripStatus()
        {
            JobTripStatusHistories = new HashSet<JobTripStatusHistory>();
            Jobs = new HashSet<Job>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<JobTripStatusHistory> JobTripStatusHistories { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
