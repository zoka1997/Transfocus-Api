using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PaymentReconciliation
    {
        public Guid Id { get; set; }
        public Guid PaymentId { get; set; }
        public Guid? JobId { get; set; }
        public Guid InvoiceId { get; set; }
        public bool? Active { get; set; }
        public decimal AmountReconciled { get; set; }
        public DateTime TimeStamp { get; set; }
        public decimal? OriginalAmount { get; set; }

        public virtual PanelInvoice Invoice { get; set; } = null!;
        public virtual Job? Job { get; set; }
        public virtual PaymentSalesLedger Payment { get; set; } = null!;
    }
}
