using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class TrailerConfiguration
    {
        public TrailerConfiguration()
        {
            FleetRunningCosts = new HashSet<FleetRunningCost>();
            Manifests = new HashSet<Manifest>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public string? Code { get; set; }

        public virtual ICollection<FleetRunningCost> FleetRunningCosts { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
    }
}
