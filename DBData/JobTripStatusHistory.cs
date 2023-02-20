using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobTripStatusHistory
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public string JobTripStatusId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public string? Description { get; set; }
        public DateTime? TimeStampUtc { get; set; }
        public Guid? ExternalJobStatusImportId { get; set; }

        public virtual ExternalJobStatusImport? ExternalJobStatusImport { get; set; }
        public virtual Job Job { get; set; } = null!;
        public virtual JobTripStatus JobTripStatus { get; set; } = null!;
    }
}
