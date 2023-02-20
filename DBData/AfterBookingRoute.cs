using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AfterBookingRoute
    {
        public AfterBookingRoute()
        {
            Companies = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Route { get; set; } = null!;

        public virtual ICollection<Company> Companies { get; set; }
    }
}
