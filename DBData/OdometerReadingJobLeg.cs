using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class OdometerReadingJobLeg
    {
        public Guid Id { get; set; }
        public Guid OdometerReadingId { get; set; }
        public Guid JobLegId { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual OdometerReading OdometerReading { get; set; } = null!;
    }
}
