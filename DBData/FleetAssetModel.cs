using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetModel
    {
        public FleetAssetModel()
        {
            FleetAssets = new HashSet<FleetAsset>();
        }

        public int Id { get; set; }
        public int FleetAssetMakeId { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }

        public virtual FleetAssetMake FleetAssetMake { get; set; } = null!;
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
    }
}
