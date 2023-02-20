using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InvoiceStatus
    {
        public InvoiceStatus()
        {
            Invoices = new HashSet<Invoice>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Invoice> Invoices { get; set; }
    }
}
