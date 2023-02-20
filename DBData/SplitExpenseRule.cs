using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SplitExpenseRule
    {
        public SplitExpenseRule()
        {
            Companies = new HashSet<Company>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Company> Companies { get; set; }
    }
}
