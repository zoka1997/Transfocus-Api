using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CreditNoteReconciliation
    {
        public Guid Id { get; set; }
        public Guid CreditNoteId { get; set; }
        public Guid? JobId { get; set; }
        public Guid InvoiceId { get; set; }
        public bool? Active { get; set; }
        public decimal AmountReconciled { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual CreditNoteSalesLedger CreditNote { get; set; } = null!;
        public virtual PanelInvoice Invoice { get; set; } = null!;
        public virtual Job? Job { get; set; }
    }
}
