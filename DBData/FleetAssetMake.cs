using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetMake
    {
        public FleetAssetMake()
        {
            FleetAssetModels = new HashSet<FleetAssetModel>();
            FleetAssets = new HashSet<FleetAsset>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }

        public virtual ICollection<FleetAssetModel> FleetAssetModels { get; set; }
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
    }
}
