using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostGroup
    {
        public CostGroup()
        {
            FleetAssets = new HashSet<FleetAsset>();
            FleetRunningCosts = new HashSet<FleetRunningCost>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid CompanyId { get; set; }

        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
        public virtual ICollection<FleetRunningCost> FleetRunningCosts { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
