using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PriceProductCard
    {
        public PriceProductCard()
        {
            Pricings = new HashSet<Pricing>();
        }

        public Guid Id { get; set; }
        public Guid? ServiceLaneId { get; set; }
        public Guid? ServiceCodeId { get; set; }
        public Guid PricingUnitId { get; set; }
        public string Description { get; set; } = null!;
        public string BreaksPrice { get; set; } = null!;
        public int BreakRules { get; set; }
        public int? AutoApplyOrder { get; set; }
        public bool? Active { get; set; }
        public string ChargeUnitId { get; set; } = null!;
        public bool ApplyFuelLevy { get; set; }
        public bool ReportSummaryInvoice { get; set; }
        public decimal MinCharge { get; set; }
        public decimal MaxCharge { get; set; }
        public string? Account { get; set; }

        public virtual PricingChargeUnit ChargeUnit { get; set; } = null!;
        public virtual Product PricingUnit { get; set; } = null!;
        public virtual ServiceCode? ServiceCode { get; set; }
        public virtual ServiceLane? ServiceLane { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
    }
}
