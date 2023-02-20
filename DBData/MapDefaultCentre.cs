using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class MapDefaultCentre
    {
        public MapDefaultCentre()
        {
            Companies = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Company> Companies { get; set; }
    }
}
