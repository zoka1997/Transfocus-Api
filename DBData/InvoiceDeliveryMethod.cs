using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InvoiceDeliveryMethod
    {
        public InvoiceDeliveryMethod()
        {
            Companies = new HashSet<Company>();
            Customers = new HashSet<Customer>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
    }
}
