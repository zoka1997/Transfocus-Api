using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingScheduleType
    {
        public PricingScheduleType()
        {
            Customers = new HashSet<Customer>();
            PricingSchedules = new HashSet<PricingSchedule>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public bool IsCustomerDefault { get; set; }
        public bool IsCompanyDefault { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PricingSchedule> PricingSchedules { get; set; }
    }
}
