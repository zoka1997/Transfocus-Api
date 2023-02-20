using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobPricing
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public Guid? PricingItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitRate { get; set; }
        public decimal TaxRate { get; set; }
        public bool ApplyFuelLevy { get; set; }
        public decimal Amount { get; set; }
        public Guid? GstcodeId { get; set; }
        public string Status { get; set; } = null!;
        public string? Description { get; set; }
        public string? ChargeUnitId { get; set; }
        public int? OrderNumber { get; set; }
        public bool ReportSummaryInvoice { get; set; }
        public Guid? JobProductId { get; set; }
        public string? Account { get; set; }

        public virtual PricingChargeUnit? ChargeUnit { get; set; }
        public virtual Gstcode? Gstcode { get; set; }
        public virtual Job Job { get; set; } = null!;
        public virtual JobProduct? JobProduct { get; set; }
        public virtual WebPanelUser ModifiedByNavigation { get; set; } = null!;
        public virtual Pricing? PricingItem { get; set; }
    }
}
