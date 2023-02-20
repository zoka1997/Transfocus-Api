using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ServiceCode
    {
        public ServiceCode()
        {
            AvailableServiceCodes = new HashSet<AvailableServiceCode>();
            CostingServiceLanes = new HashSet<CostingServiceLane>();
            JobLegs = new HashSet<JobLeg>();
            Jobs = new HashSet<Job>();
            Manifests = new HashSet<Manifest>();
            PriceJobTotals = new HashSet<PriceJobTotal>();
            PriceProductCards = new HashSet<PriceProductCard>();
            RangePricings = new HashSet<RangePricing>();
            ServiceCodeProducts = new HashSet<ServiceCodeProduct>();
            ServiceLanes = new HashSet<ServiceLane>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }
        public bool Active { get; set; }
        public Guid CompanyId { get; set; }
        public int CubicWeightConvRate { get; set; }
        public bool SubcontractorOnly { get; set; }
        public bool IsInternal { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<AvailableServiceCode> AvailableServiceCodes { get; set; }
        public virtual ICollection<CostingServiceLane> CostingServiceLanes { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<PriceJobTotal> PriceJobTotals { get; set; }
        public virtual ICollection<PriceProductCard> PriceProductCards { get; set; }
        public virtual ICollection<RangePricing> RangePricings { get; set; }
        public virtual ICollection<ServiceCodeProduct> ServiceCodeProducts { get; set; }
        public virtual ICollection<ServiceLane> ServiceLanes { get; set; }
    }
}
