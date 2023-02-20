using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PalletType
    {
        public PalletType()
        {
            JobLegPallets = new HashSet<JobLegPallet>();
            JobLegProducts = new HashSet<JobLegProduct>();
            JobProducts = new HashSet<JobProduct>();
            PalletTransactions = new HashSet<PalletTransaction>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<JobLegPallet> JobLegPallets { get; set; }
        public virtual ICollection<JobLegProduct> JobLegProducts { get; set; }
        public virtual ICollection<JobProduct> JobProducts { get; set; }
        public virtual ICollection<PalletTransaction> PalletTransactions { get; set; }
    }
}
