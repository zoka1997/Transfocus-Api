using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Country
    {
        public Country()
        {
            Companies = new HashSet<Company>();
            Customers = new HashSet<Customer>();
            Locations = new HashSet<Location>();
            PublicHolidays = new HashSet<PublicHoliday>();
            States = new HashSet<State>();
            Subcontractors = new HashSet<Subcontractor>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool Active { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<PublicHoliday> PublicHolidays { get; set; }
        public virtual ICollection<State> States { get; set; }
        public virtual ICollection<Subcontractor> Subcontractors { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
