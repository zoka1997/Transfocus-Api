using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class GenericGroup
    {
        public GenericGroup()
        {
            CustomerGroup1s = new HashSet<Customer>();
            CustomerGroup2s = new HashSet<Customer>();
            FleetAssetGroup1s = new HashSet<FleetAsset>();
            FleetAssetGroup2s = new HashSet<FleetAsset>();
            JobGroup1s = new HashSet<Job>();
            JobGroup2s = new HashSet<Job>();
            LocationGroup1s = new HashSet<Location>();
            LocationGroup2s = new HashSet<Location>();
            PricingGroup1s = new HashSet<Pricing>();
            PricingGroup2s = new HashSet<Pricing>();
            ProductGroup1s = new HashSet<Product>();
            ProductGroup2s = new HashSet<Product>();
            ZoneGroup1s = new HashSet<Zone>();
            ZoneGroup2s = new HashSet<Zone>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public bool Active { get; set; }
        public string? GroupType { get; set; }
        public string? GroupNumber { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<Customer> CustomerGroup1s { get; set; }
        public virtual ICollection<Customer> CustomerGroup2s { get; set; }
        public virtual ICollection<FleetAsset> FleetAssetGroup1s { get; set; }
        public virtual ICollection<FleetAsset> FleetAssetGroup2s { get; set; }
        public virtual ICollection<Job> JobGroup1s { get; set; }
        public virtual ICollection<Job> JobGroup2s { get; set; }
        public virtual ICollection<Location> LocationGroup1s { get; set; }
        public virtual ICollection<Location> LocationGroup2s { get; set; }
        public virtual ICollection<Pricing> PricingGroup1s { get; set; }
        public virtual ICollection<Pricing> PricingGroup2s { get; set; }
        public virtual ICollection<Product> ProductGroup1s { get; set; }
        public virtual ICollection<Product> ProductGroup2s { get; set; }
        public virtual ICollection<Zone> ZoneGroup1s { get; set; }
        public virtual ICollection<Zone> ZoneGroup2s { get; set; }
    }
}
