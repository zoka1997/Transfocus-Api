using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostProductCard
    {
        public CostProductCard()
        {
            CostingOptionalItems = new HashSet<CostingOptionalItem>();
        }

        public Guid Id { get; set; }
        public Guid ServiceLaneId { get; set; }
        public Guid CostingUnitId { get; set; }
        public string Description { get; set; } = null!;
        public string BreaksCost { get; set; } = null!;
        public int BreakRules { get; set; }
        public int? AutoApplyOrder { get; set; }
        public bool? Active { get; set; }
        public string ChargeUnitId { get; set; } = null!;
        public bool ApplyFuelLevy { get; set; }

        public virtual PricingChargeUnit ChargeUnit { get; set; } = null!;
        public virtual Product CostingUnit { get; set; } = null!;
        public virtual CostingServiceLane ServiceLane { get; set; } = null!;
        public virtual ICollection<CostingOptionalItem> CostingOptionalItems { get; set; }
    }
}
