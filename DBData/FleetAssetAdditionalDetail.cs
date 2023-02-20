using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetAdditionalDetail
    {
        public Guid Id { get; set; }
        public Guid FleetAssetId { get; set; }
        public string Category { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Value { get; set; } = null!;
        public Guid? CompanyId { get; set; }

        public virtual FleetAsset FleetAsset { get; set; } = null!;
    }
}
