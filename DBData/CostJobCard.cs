using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostJobCard
    {
        public Guid Id { get; set; }
        public Guid ServiceLaneId { get; set; }
        public string ChargeUnitId { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string BreaksCost { get; set; } = null!;
        public int BreakRules { get; set; }
        public int? AutoApplyOrder { get; set; }
        public bool? Active { get; set; }
        public bool ApplyFuelLevy { get; set; }

        public virtual PricingChargeUnit ChargeUnit { get; set; } = null!;
        public virtual CostingServiceLane ServiceLane { get; set; } = null!;
    }
}
