using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ExternalJobStatus
    {
        public ExternalJobStatus()
        {
            ExternalJobStatusImports = new HashSet<ExternalJobStatusImport>();
            ExternalJobStatusMappings = new HashSet<ExternalJobStatusMapping>();
        }

        public Guid Id { get; set; }
        public string? Name { get; set; }
        public Guid? SubcontractorId { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual ICollection<ExternalJobStatusImport> ExternalJobStatusImports { get; set; }
        public virtual ICollection<ExternalJobStatusMapping> ExternalJobStatusMappings { get; set; }
    }
}
