using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AspnetUser
    {
        public AspnetUser()
        {
            AspnetPersonalizationPerUsers = new HashSet<AspnetPersonalizationPerUser>();
            SubcontractorPayments = new HashSet<SubcontractorPayment>();
            Roles = new HashSet<AspnetRole>();
        }

        public Guid ApplicationId { get; set; }
        public Guid UserId { get; set; }
        public string UserName { get; set; } = null!;
        public string LoweredUserName { get; set; } = null!;
        public string? MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        public DateTime LastActivityDate { get; set; }

        public virtual AspnetApplication Application { get; set; } = null!;
        public virtual AspnetMembership? AspnetMembership { get; set; }
        public virtual AspnetProfile? AspnetProfile { get; set; }
        public virtual ICollection<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; }
        public virtual ICollection<SubcontractorPayment> SubcontractorPayments { get; set; }

        public virtual ICollection<AspnetRole> Roles { get; set; }
    }
}
