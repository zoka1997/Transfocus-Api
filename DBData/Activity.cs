using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Activity
    {
        public Activity()
        {
            JobLegActivities = new HashSet<JobLegActivity>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? Active { get; set; }
        public Guid CompanyId { get; set; }
        public string? Code { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<JobLegActivity> JobLegActivities { get; set; }
    }
}
