using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PalletAddressAccount
    {
        public Guid Id { get; set; }
        public int? PalletDays { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? PalletAccountId { get; set; }

        public virtual Location? Location { get; set; }
        public virtual PalletAccount? PalletAccount { get; set; }
    }
}
