using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ExternalJobStatusMapping
    {
        public int Id { get; set; }
        public Guid? ExternalJobStatusId { get; set; }
        public string? Description { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? InternalTrackStatusId { get; set; }

        public virtual ExternalJobStatus? ExternalJobStatus { get; set; }
        public virtual InternalTrackStatus? InternalTrackStatus { get; set; }
    }
}
