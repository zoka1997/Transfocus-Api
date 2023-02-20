using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetAxleWeight
    {
        public Guid Id { get; set; }
        public Guid FleetAssetId { get; set; }
        public string? Name { get; set; }
        public decimal Value { get; set; }

        public virtual FleetAsset FleetAsset { get; set; } = null!;
    }
}
