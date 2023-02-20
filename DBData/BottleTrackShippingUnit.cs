using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class BottleTrackShippingUnit
    {
        public Guid Id { get; set; }
        public Guid BottleTrackId { get; set; }
        public string Name { get; set; } = null!;
        public decimal Quantity { get; set; }
        public decimal EmptyQuantity { get; set; }
        public decimal? Weight { get; set; }

        public virtual BottleTrack BottleTrack { get; set; } = null!;
    }
}
