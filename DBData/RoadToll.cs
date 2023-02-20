using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RoadToll
    {
        public Guid Id { get; set; }
        public int GeneralTollsId { get; set; }
        public Guid? ManifestId { get; set; }
        public Guid? JobId { get; set; }
        public int Quantity { get; set; }

        public virtual GeneralToll GeneralTolls { get; set; } = null!;
        public virtual Job? Job { get; set; }
        public virtual Manifest? Manifest { get; set; }
    }
}
