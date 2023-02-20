using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingDependence
    {
        public Guid Id { get; set; }
        public Guid PricingId { get; set; }
        public Guid DependedId { get; set; }

        public virtual Pricing Depended { get; set; } = null!;
        public virtual Pricing Pricing { get; set; } = null!;
    }
}
