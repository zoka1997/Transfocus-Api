using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PalletMovementType
    {
        public PalletMovementType()
        {
            JobLegPallets = new HashSet<JobLegPallet>();
            PalletTransactions = new HashSet<PalletTransaction>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<JobLegPallet> JobLegPallets { get; set; }
        public virtual ICollection<PalletTransaction> PalletTransactions { get; set; }
    }
}
