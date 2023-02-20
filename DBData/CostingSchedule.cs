using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostingSchedule
    {
        public CostingSchedule()
        {
            CostingServiceLanes = new HashSet<CostingServiceLane>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string CostingScheduleStatusId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Guid? SubcontractorId { get; set; }
        public bool IsManifestCost { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CostingScheduleStatus CostingScheduleStatus { get; set; } = null!;
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual ICollection<CostingServiceLane> CostingServiceLanes { get; set; }
    }
}
