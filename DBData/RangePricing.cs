using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RangePricing
    {
        public Guid Id { get; set; }
        public Guid PricingId { get; set; }
        public Guid? CustomerId { get; set; }
        public decimal Rate { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime ModifiedOn { get; set; }
        public DateTime DateFrom { get; set; }
        public DateTime DateTo { get; set; }
        public Guid? ServiceCodeId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual WebPanelUser ModifiedByNavigation { get; set; } = null!;
        public virtual Pricing Pricing { get; set; } = null!;
        public virtual ServiceCode? ServiceCode { get; set; }
    }
}
