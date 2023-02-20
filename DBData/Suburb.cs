using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Suburb
    {
        public Suburb()
        {
            CompanyPostalSuburbs = new HashSet<Company>();
            CompanySuburbNavigations = new HashSet<Company>();
            Locations = new HashSet<Location>();
            SubcontractorLocationZones = new HashSet<SubcontractorLocationZone>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string StateId { get; set; } = null!;
        public int Postcode { get; set; }
        public Guid? PricingZoneId { get; set; }
        public Guid? CostingZoneId { get; set; }
        public Guid? ZoneId { get; set; }
        public Guid? CompanyId { get; set; }
        public bool? Active { get; set; }
        public Guid? DepotZoneId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Zone? CostingZone { get; set; }
        public virtual Zone? DepotZone { get; set; }
        public virtual Zone? PricingZone { get; set; }
        public virtual State State { get; set; } = null!;
        public virtual Zone? Zone { get; set; }
        public virtual ICollection<Company> CompanyPostalSuburbs { get; set; }
        public virtual ICollection<Company> CompanySuburbNavigations { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<SubcontractorLocationZone> SubcontractorLocationZones { get; set; }
    }
}
