using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InvoiceSalesJournalExportedInvoice
    {
        public int Id { get; set; }
        public Guid? InvoiceSalesJournalExportId { get; set; }
        public Guid? PanelInvoiceId { get; set; }

        public virtual InvoiceSalesJournalExport? InvoiceSalesJournalExport { get; set; }
        public virtual PanelInvoice? PanelInvoice { get; set; }
    }
}
