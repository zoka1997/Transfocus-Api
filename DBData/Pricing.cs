using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Pricing
    {
        public Pricing()
        {
            CustomActivities = new HashSet<CustomActivity>();
            JobLegCostings = new HashSet<JobLegCosting>();
            JobPricings = new HashSet<JobPricing>();
            PricingDependenceDependeds = new HashSet<PricingDependence>();
            PricingDependencePricings = new HashSet<PricingDependence>();
            PricingHistories = new HashSet<PricingHistory>();
            PricingInvoices = new HashSet<PricingInvoice>();
            Products = new HashSet<Product>();
            RangePricings = new HashSet<RangePricing>();
        }

        public Guid Id { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? CustomerId { get; set; }
        public string Code { get; set; } = null!;
        public string Description { get; set; } = null!;
        public string ChargeUnitId { get; set; } = null!;
        public decimal? DefaultUnitRate { get; set; }
        public bool ApplyFuelLevy { get; set; }
        public string Account { get; set; } = null!;
        public int? AutoApplyOrder { get; set; }
        public bool Active { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedOn { get; set; }
        public bool IsFuelLevy { get; set; }
        public Guid? ServiceLaneId { get; set; }
        public decimal TaxRate { get; set; }
        public Guid? JobCodeId { get; set; }
        public Guid? GstcodeId { get; set; }
        public bool AutoApply { get; set; }
        public bool ListRate { get; set; }
        public bool? ShowRate { get; set; }
        public Guid? PriceProductCardId { get; set; }
        public bool IsSystemItem { get; set; }
        public bool UseHistory { get; set; }
        public bool ReportSummaryInvoice { get; set; }
        public int RuleId { get; set; }
        public string? RuleSettings { get; set; }
        public bool NotApplyDroppedDepot { get; set; }
        public bool NotApplyPickedDepot { get; set; }
        public bool IsCostItem { get; set; }
        public string? AccountingSystem { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsXero { get; set; }
        public string? PricingCodeXero { get; set; }
        public string? XeroAccountCode { get; set; }
        public Guid? SubcontractorId { get; set; }
        public bool UseMaxChargeFromFirstFlat { get; set; }
        public bool IncludeToMaxCharge { get; set; }
        public bool IncludeToMinCharge { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? Group2Id { get; set; }
        public decimal? DefQty { get; set; }

        public virtual PricingChargeUnit ChargeUnit { get; set; } = null!;
        public virtual Company? Company { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual Gstcode? Gstcode { get; set; }
        public virtual JobCode? JobCode { get; set; }
        public virtual WebPanelUser ModifiedByNavigation { get; set; } = null!;
        public virtual PriceProductCard? PriceProductCard { get; set; }
        public virtual ServiceLane? ServiceLane { get; set; }
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual ICollection<CustomActivity> CustomActivities { get; set; }
        public virtual ICollection<JobLegCosting> JobLegCostings { get; set; }
        public virtual ICollection<JobPricing> JobPricings { get; set; }
        public virtual ICollection<PricingDependence> PricingDependenceDependeds { get; set; }
        public virtual ICollection<PricingDependence> PricingDependencePricings { get; set; }
        public virtual ICollection<PricingHistory> PricingHistories { get; set; }
        public virtual ICollection<PricingInvoice> PricingInvoices { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RangePricing> RangePricings { get; set; }
    }
}
