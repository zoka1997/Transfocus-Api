using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class BottleTrack
    {
        public BottleTrack()
        {
            BottleTrackShippingUnits = new HashSet<BottleTrackShippingUnit>();
        }

        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public DateTime TimeStamp { get; set; }
        public bool? Active { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual ICollection<BottleTrackShippingUnit> BottleTrackShippingUnits { get; set; }
    }
}
