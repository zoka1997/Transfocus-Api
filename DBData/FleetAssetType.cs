using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetType
    {
        public FleetAssetType()
        {
            Compliances = new HashSet<Compliance>();
            FleetAssetSubtypes = new HashSet<FleetAssetSubtype>();
            FleetAssets = new HashSet<FleetAsset>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsVehicle { get; set; }
        public string? FoxProCode { get; set; }

        public virtual ICollection<Compliance> Compliances { get; set; }
        public virtual ICollection<FleetAssetSubtype> FleetAssetSubtypes { get; set; }
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
    }
}
