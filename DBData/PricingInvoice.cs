using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingInvoice
    {
        public Guid Id { get; set; }
        public Guid PricingItemId { get; set; }
        public Guid InvoiceId { get; set; }
        public string? InvoiceNumber { get; set; }
        public DateTime Timestamp { get; set; }
        public string? ModifiedBy { get; set; }
        public decimal? Quantity { get; set; }
        public decimal? TaxRate { get; set; }
        public bool? ApplyFuelLevy { get; set; }
        public decimal? Amount { get; set; }
        public Guid? GstcodeId { get; set; }
        public string? ChargeUnit { get; set; }
        public decimal? UnitRate { get; set; }
        public string? Description { get; set; }

        public virtual PricingChargeUnit? ChargeUnitNavigation { get; set; }
        public virtual Gstcode? Gstcode { get; set; }
        public virtual PanelInvoice Invoice { get; set; } = null!;
        public virtual Pricing PricingItem { get; set; } = null!;
    }
}
