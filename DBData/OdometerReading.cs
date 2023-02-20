using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class OdometerReading
    {
        public OdometerReading()
        {
            OdometerReadingJobLegs = new HashSet<OdometerReadingJobLeg>();
        }

        public Guid Id { get; set; }
        public Guid VehicleId { get; set; }
        public decimal? ReadingOnStart { get; set; }
        public decimal? ReadingOnFinish { get; set; }
        public DateTime ReadingTimestamp { get; set; }

        public virtual FleetAsset Vehicle { get; set; } = null!;
        public virtual ICollection<OdometerReadingJobLeg> OdometerReadingJobLegs { get; set; }
    }
}
