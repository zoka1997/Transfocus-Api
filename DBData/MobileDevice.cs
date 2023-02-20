using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class MobileDevice
    {
        public MobileDevice()
        {
            AuthTokens = new HashSet<AuthToken>();
        }

        public Guid Id { get; set; }
        public string SerialNumber { get; set; } = null!;
        public bool Active { get; set; }
        public string? Name { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<AuthToken> AuthTokens { get; set; }
    }
}
