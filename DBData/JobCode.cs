using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobCode
    {
        public JobCode()
        {
            FleetAssets = new HashSet<FleetAsset>();
            Pricings = new HashSet<Pricing>();
            Vehicles = new HashSet<Vehicle>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public bool? Active { get; set; }
        public Guid CompanyId { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Timestamp { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
