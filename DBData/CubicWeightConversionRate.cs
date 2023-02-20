using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CubicWeightConversionRate
    {
        public CubicWeightConversionRate()
        {
            Companies = new HashSet<Company>();
        }

        public Guid Id { get; set; }
        public int Rate { get; set; }
        public Guid? CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
