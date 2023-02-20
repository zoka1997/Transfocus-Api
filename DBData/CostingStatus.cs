using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostingStatus
    {
        public CostingStatus()
        {
            JobLegCostingStatusHistories = new HashSet<JobLegCostingStatusHistory>();
            JobLegs = new HashSet<JobLeg>();
            Manifests = new HashSet<Manifest>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }

        public virtual ICollection<JobLegCostingStatusHistory> JobLegCostingStatusHistories { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
    }
}
