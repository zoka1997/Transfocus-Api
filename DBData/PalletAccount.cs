using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PalletAccount
    {
        public PalletAccount()
        {
            PalletAddressAccounts = new HashSet<PalletAddressAccount>();
        }

        public Guid Id { get; set; }
        public string PalletCompany { get; set; } = null!;
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public Guid? LocationId { get; set; }
        public int Type { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual Location? Location { get; set; }
        public virtual ICollection<PalletAddressAccount> PalletAddressAccounts { get; set; }
    }
}
