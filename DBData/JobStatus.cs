using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobStatus
    {
        public JobStatus()
        {
            JobHistories = new HashSet<JobHistory>();
            Jobs = new HashSet<Job>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }
        public int? OrderNo { get; set; }

        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
