using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostingServiceLane
    {
        public CostingServiceLane()
        {
            CostJobCards = new HashSet<CostJobCard>();
            CostProductCards = new HashSet<CostProductCard>();
            CostingOptionalItems = new HashSet<CostingOptionalItem>();
        }

        public Guid Id { get; set; }
        public Guid CostingScheduleId { get; set; }
        public string Name { get; set; } = null!;
        public Guid FromCostingZone { get; set; }
        public Guid ToCostingZone { get; set; }
        public Guid ServiceCodeId { get; set; }
        public decimal MinCharge { get; set; }
        public bool Reverse { get; set; }

        public virtual CostingSchedule CostingSchedule { get; set; } = null!;
        public virtual Zone FromCostingZoneNavigation { get; set; } = null!;
        public virtual ServiceCode ServiceCode { get; set; } = null!;
        public virtual Zone ToCostingZoneNavigation { get; set; } = null!;
        public virtual ICollection<CostJobCard> CostJobCards { get; set; }
        public virtual ICollection<CostProductCard> CostProductCards { get; set; }
        public virtual ICollection<CostingOptionalItem> CostingOptionalItems { get; set; }
    }
}
