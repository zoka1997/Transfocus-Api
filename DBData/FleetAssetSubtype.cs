using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetSubtype
    {
        public FleetAssetSubtype()
        {
            Compliances = new HashSet<Compliance>();
            FleetAssets = new HashSet<FleetAsset>();
        }

        public int Id { get; set; }
        public int? FleetAssetTypeId { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public string? AddedBy { get; set; }
        public DateTime? AddedDate { get; set; }

        public virtual FleetAssetType? FleetAssetType { get; set; }
        public virtual ICollection<Compliance> Compliances { get; set; }
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
    }
}
