using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ExternalJobStatusImport
    {
        public ExternalJobStatusImport()
        {
            JobTripStatusHistories = new HashSet<JobTripStatusHistory>();
        }

        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public Guid? ExternalJobStatusId { get; set; }
        public DateTime? Timestamp { get; set; }

        public virtual ExternalJobStatus? ExternalJobStatus { get; set; }
        public virtual Job? Job { get; set; }
        public virtual ICollection<JobTripStatusHistory> JobTripStatusHistories { get; set; }
    }
}
