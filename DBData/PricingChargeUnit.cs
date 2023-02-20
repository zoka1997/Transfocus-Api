using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingChargeUnit
    {
        public PricingChargeUnit()
        {
            CostJobCards = new HashSet<CostJobCard>();
            CostProductCards = new HashSet<CostProductCard>();
            CostingOptionalItems = new HashSet<CostingOptionalItem>();
            JobPricings = new HashSet<JobPricing>();
            PriceJobTotals = new HashSet<PriceJobTotal>();
            PriceProductCards = new HashSet<PriceProductCard>();
            PricingInvoices = new HashSet<PricingInvoice>();
            Pricings = new HashSet<Pricing>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<CostJobCard> CostJobCards { get; set; }
        public virtual ICollection<CostProductCard> CostProductCards { get; set; }
        public virtual ICollection<CostingOptionalItem> CostingOptionalItems { get; set; }
        public virtual ICollection<JobPricing> JobPricings { get; set; }
        public virtual ICollection<PriceJobTotal> PriceJobTotals { get; set; }
        public virtual ICollection<PriceProductCard> PriceProductCards { get; set; }
        public virtual ICollection<PricingInvoice> PricingInvoices { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
    }
}
