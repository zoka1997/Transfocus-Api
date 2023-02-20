using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ProductPriceEnquiryView
    {
        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public string? ScheduleName { get; set; }
        public string? Service { get; set; }
        public string? FromZone { get; set; }
        public string? ToZone { get; set; }
        public string? PricingUnit { get; set; }
        public string Description { get; set; } = null!;
        public int BreakRules { get; set; }
        public string BreaksPrice { get; set; } = null!;
        public string? OptionalPricing { get; set; }
        public string? OptionalPricingDescription { get; set; }
        public string? ProductDescription { get; set; }
        public string? ChargeUnit { get; set; }
        public decimal MinCharge { get; set; }
        public decimal MaxCharge { get; set; }
        public bool ApplyFuelLevy { get; set; }
        public bool ReportSummaryInvoice { get; set; }
        public bool Active { get; set; }
    }
}
