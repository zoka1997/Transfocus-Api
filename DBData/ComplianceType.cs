using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ComplianceType
    {
        public ComplianceType()
        {
            Compliances = new HashSet<Compliance>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Compliance> Compliances { get; set; }
    }
}
