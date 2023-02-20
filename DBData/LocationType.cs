using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class LocationType
    {
        public LocationType()
        {
            Locations = new HashSet<Location>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Location> Locations { get; set; }
    }
}
