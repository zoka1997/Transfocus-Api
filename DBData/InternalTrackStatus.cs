using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InternalTrackStatus
    {
        public InternalTrackStatus()
        {
            ExternalJobStatusMappings = new HashSet<ExternalJobStatusMapping>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }

        public virtual ICollection<ExternalJobStatusMapping> ExternalJobStatusMappings { get; set; }
    }
}
