using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingHistory
    {
        public Guid Id { get; set; }
        public Guid PricingId { get; set; }
        public decimal Rate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }

        public virtual Pricing Pricing { get; set; } = null!;
    }
}
