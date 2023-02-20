using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobImportMode
    {
        public JobImportMode()
        {
            AutomaticEdilogs = new HashSet<AutomaticEdilog>();
            Companies = new HashSet<Company>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid CompanyId { get; set; }
        public bool AutoCreateMissingData { get; set; }
        public string? MethodId { get; set; }
        public string? MatchId { get; set; }
        public string? RejectMethodId { get; set; }
        public bool? Active { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual JobImportMatch? Match { get; set; }
        public virtual JobImportMethod? Method { get; set; }
        public virtual JobImportRejectMethod? RejectMethod { get; set; }
        public virtual ICollection<AutomaticEdilog> AutomaticEdilogs { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
