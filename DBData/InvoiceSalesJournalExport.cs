using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InvoiceSalesJournalExport
    {
        public InvoiceSalesJournalExport()
        {
            InvoiceSalesJournalExportedInvoices = new HashSet<InvoiceSalesJournalExportedInvoice>();
        }

        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? UserName { get; set; }
        public string? IpAddress { get; set; }
        public Guid? CompanyId { get; set; }
        public string? Description { get; set; }

        public virtual ICollection<InvoiceSalesJournalExportedInvoice> InvoiceSalesJournalExportedInvoices { get; set; }
    }
}
