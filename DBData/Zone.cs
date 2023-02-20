using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Zone
    {
        public Zone()
        {
            CostingServiceLaneFromCostingZoneNavigations = new HashSet<CostingServiceLane>();
            CostingServiceLaneToCostingZoneNavigations = new HashSet<CostingServiceLane>();
            LocationCostingZones = new HashSet<Location>();
            LocationDepotZones = new HashSet<Location>();
            LocationPricingZones = new HashSet<Location>();
            LocationZones = new HashSet<Location>();
            Manifests = new HashSet<Manifest>();
            ServiceLaneFromPricingZoneNavigations = new HashSet<ServiceLane>();
            ServiceLaneToPricingZoneNavigations = new HashSet<ServiceLane>();
            SubcontractorLocationZones = new HashSet<SubcontractorLocationZone>();
            SuburbCostingZones = new HashSet<Suburb>();
            SuburbDepotZones = new HashSet<Suburb>();
            SuburbPricingZones = new HashSet<Suburb>();
            SuburbZones = new HashSet<Suburb>();
            Users = new HashSet<User>();
            ZonesMultis = new HashSet<ZonesMulti>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime Timestamp { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public string? Code { get; set; }
        public string Name { get; set; } = null!;
        public string ZoneTypeId { get; set; } = null!;
        public bool? Active { get; set; }
        public Guid? CustomerId { get; set; }
        public bool IsSystem { get; set; }
        public Guid? SubcontractorId { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? Group2Id { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual WebPanelUser ModifiedByNavigation { get; set; } = null!;
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual ZoneType ZoneType { get; set; } = null!;
        public virtual ICollection<CostingServiceLane> CostingServiceLaneFromCostingZoneNavigations { get; set; }
        public virtual ICollection<CostingServiceLane> CostingServiceLaneToCostingZoneNavigations { get; set; }
        public virtual ICollection<Location> LocationCostingZones { get; set; }
        public virtual ICollection<Location> LocationDepotZones { get; set; }
        public virtual ICollection<Location> LocationPricingZones { get; set; }
        public virtual ICollection<Location> LocationZones { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<ServiceLane> ServiceLaneFromPricingZoneNavigations { get; set; }
        public virtual ICollection<ServiceLane> ServiceLaneToPricingZoneNavigations { get; set; }
        public virtual ICollection<SubcontractorLocationZone> SubcontractorLocationZones { get; set; }
        public virtual ICollection<Suburb> SuburbCostingZones { get; set; }
        public virtual ICollection<Suburb> SuburbDepotZones { get; set; }
        public virtual ICollection<Suburb> SuburbPricingZones { get; set; }
        public virtual ICollection<Suburb> SuburbZones { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<ZonesMulti> ZonesMultis { get; set; }
    }
}
