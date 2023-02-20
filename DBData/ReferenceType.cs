using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ReferenceType
    {
        public ReferenceType()
        {
            References = new HashSet<Reference>();
        }

        public Guid Id { get; set; }
        public string TableName { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int SortOrder { get; set; }
        public bool? Active { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<Reference> References { get; set; }
    }
}
