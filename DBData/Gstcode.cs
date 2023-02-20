using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Gstcode
    {
        public Gstcode()
        {
            Companies = new HashSet<Company>();
            Customers = new HashSet<Customer>();
            JobPricings = new HashSet<JobPricing>();
            PricingInvoices = new HashSet<PricingInvoice>();
            Pricings = new HashSet<Pricing>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public decimal? Value { get; set; }

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<JobPricing> JobPricings { get; set; }
        public virtual ICollection<PricingInvoice> PricingInvoices { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
    }
}
