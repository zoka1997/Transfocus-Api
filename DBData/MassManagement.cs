using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class MassManagement
    {
        public MassManagement()
        {
            MassManagementJobLegs = new HashSet<MassManagementJobLeg>();
        }

        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public Guid? Trailer1Id { get; set; }
        public Guid? Trailer2Id { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? Steer { get; set; }
        public decimal? Drive { get; set; }
        public decimal? TriAxle1 { get; set; }
        public decimal? TriAxle2 { get; set; }
        public DateTime ReadingTimestamp { get; set; }

        public virtual Vehicle? Trailer1 { get; set; }
        public virtual Vehicle? Trailer2 { get; set; }
        public virtual Vehicle Vehicle { get; set; } = null!;
        public virtual ICollection<MassManagementJobLeg> MassManagementJobLegs { get; set; }
    }
}
