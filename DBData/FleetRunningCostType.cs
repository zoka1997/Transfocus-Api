using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetRunningCostType
    {
        public FleetRunningCostType()
        {
            FleetRunningCosts = new HashSet<FleetRunningCost>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<FleetRunningCost> FleetRunningCosts { get; set; }
    }
}
