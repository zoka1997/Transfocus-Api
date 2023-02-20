using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Podexception
    {
        public Podexception()
        {
            JobLegs = new HashSet<JobLeg>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string PodstatusId { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual Podstatus Podstatus { get; set; } = null!;
        public virtual ICollection<JobLeg> JobLegs { get; set; }
    }
}
