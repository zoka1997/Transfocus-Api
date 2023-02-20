using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobKind
    {
        public JobKind()
        {
            JobLegs = new HashSet<JobLeg>();
            Jobs = new HashSet<Job>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
