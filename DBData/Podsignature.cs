using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Podsignature
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public DateTime Timestamp { get; set; }
        public int Kind { get; set; }
        public bool EdiStatus { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
    }
}
