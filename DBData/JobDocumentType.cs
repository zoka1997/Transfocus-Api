using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobDocumentType
    {
        public JobDocumentType()
        {
            JobDocuments = new HashSet<JobDocument>();
        }

        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public bool IsRequired { get; set; }
        public int? SortOrder { get; set; }
        public bool Active { get; set; }
        public bool SendToDriver { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<JobDocument> JobDocuments { get; set; }
    }
}
