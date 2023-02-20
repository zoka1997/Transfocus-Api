using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class LegCreationMethod
    {
        public LegCreationMethod()
        {
            Companies = new HashSet<Company>();
        }

        public string Id { get; set; } = null!;
        public string LegCreationMethodName { get; set; } = null!;

        public virtual ICollection<Company> Companies { get; set; }
    }
}
