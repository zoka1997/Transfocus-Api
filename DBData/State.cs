using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class State
    {
        public State()
        {
            CompanyPostalStates = new HashSet<Company>();
            CompanyStateNavigations = new HashSet<Company>();
            GeneralTolls = new HashSet<GeneralToll>();
            Locations = new HashSet<Location>();
            Suburbs = new HashSet<Suburb>();
        }

        public string Id { get; set; } = null!;
        public string? Name { get; set; }
        public int CountryId { get; set; }

        public virtual Country Country { get; set; } = null!;
        public virtual ICollection<Company> CompanyPostalStates { get; set; }
        public virtual ICollection<Company> CompanyStateNavigations { get; set; }
        public virtual ICollection<GeneralToll> GeneralTolls { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<Suburb> Suburbs { get; set; }
    }
}
