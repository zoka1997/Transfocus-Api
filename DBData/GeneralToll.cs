using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class GeneralToll
    {
        public GeneralToll()
        {
            CompanyTolls = new HashSet<CompanyToll>();
            RoadTolls = new HashSet<RoadToll>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string StateId { get; set; } = null!;

        public virtual State State { get; set; } = null!;
        public virtual ICollection<CompanyToll> CompanyTolls { get; set; }
        public virtual ICollection<RoadToll> RoadTolls { get; set; }
    }
}
