using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostingOptionalItem
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ChargeUnitId { get; set; } = null!;
        public decimal? DefaultUnitRate { get; set; }
        public bool ApplyFuelLevy { get; set; }
        public int? AutoApplyOrder { get; set; }
        public bool Active { get; set; }
        public Guid ServiceLaneId { get; set; }
        public bool AutoApply { get; set; }
        public Guid? CostProductCardId { get; set; }
        public bool NotApplyDroppedDepot { get; set; }
        public bool NotApplyPickedDepot { get; set; }

        public virtual PricingChargeUnit ChargeUnit { get; set; } = null!;
        public virtual CostProductCard? CostProductCard { get; set; }
        public virtual CostingServiceLane ServiceLane { get; set; } = null!;
    }
}
