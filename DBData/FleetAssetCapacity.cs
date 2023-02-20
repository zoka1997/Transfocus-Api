using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetCapacity
    {
        public Guid Id { get; set; }
        public Guid FleetAssetId { get; set; }
        public string? Name { get; set; }
        public int? Pallets { get; set; }
        public int? Spaces { get; set; }
        public decimal? CubicSum { get; set; }
        public decimal? InternalHeight { get; set; }
        public decimal? InternalWidth { get; set; }
        public decimal? InternalLength { get; set; }
        public decimal? Tare { get; set; }
        public decimal? Gcm { get; set; }
        public decimal? Gvm { get; set; }

        public virtual FleetAsset FleetAsset { get; set; } = null!;
    }
}
