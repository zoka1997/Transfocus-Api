using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ServiceLane
    {
        public ServiceLane()
        {
            PriceJobTotals = new HashSet<PriceJobTotal>();
            PriceProductCards = new HashSet<PriceProductCard>();
            Pricings = new HashSet<Pricing>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? PricingScheduleId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? DriverId { get; set; }
        public string Name { get; set; } = null!;
        public Guid FromPricingZone { get; set; }
        public Guid ToPricingZone { get; set; }
        public string ServiceLaneStatusId { get; set; } = null!;
        public Guid ServiceCodeId { get; set; }
        public decimal MinCharge { get; set; }
        public bool Reverse { get; set; }
        public string? Notes { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual Zone FromPricingZoneNavigation { get; set; } = null!;
        public virtual PricingSchedule? PricingSchedule { get; set; }
        public virtual ServiceCode ServiceCode { get; set; } = null!;
        public virtual ServiceLaneStatus ServiceLaneStatus { get; set; } = null!;
        public virtual Zone ToPricingZoneNavigation { get; set; } = null!;
        public virtual ICollection<PriceJobTotal> PriceJobTotals { get; set; }
        public virtual ICollection<PriceProductCard> PriceProductCards { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
    }
}
