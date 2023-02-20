using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PersonalLocationType
    {
        public PersonalLocationType()
        {
            PersonalCustomerLocations = new HashSet<PersonalCustomerLocation>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<PersonalCustomerLocation> PersonalCustomerLocations { get; set; }
    }
}
