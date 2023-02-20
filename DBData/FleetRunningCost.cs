using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetRunningCost
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public int FleetRunningCostTypeId { get; set; }
        public int? CostGroupId { get; set; }
        public int? TrailerConfigurationId { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal? Kilometers { get; set; }
        public decimal? Hours { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CostGroup? CostGroup { get; set; }
        public virtual FleetRunningCostType FleetRunningCostType { get; set; } = null!;
        public virtual TrailerConfiguration? TrailerConfiguration { get; set; }
    }
}
