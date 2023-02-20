using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ZoneType
    {
        public ZoneType()
        {
            Zones = new HashSet<Zone>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Zone> Zones { get; set; }
    }
}
