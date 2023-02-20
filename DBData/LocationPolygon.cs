using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class LocationPolygon
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public int Ordinal { get; set; }

        public virtual Location Location { get; set; } = null!;
    }
}
