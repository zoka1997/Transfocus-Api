using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CreditNoteSalesLedger
    {
        public CreditNoteSalesLedger()
        {
            CreditNoteReconciliations = new HashSet<CreditNoteReconciliation>();
            PanelInvoices = new HashSet<PanelInvoice>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string CreditNoteNumber { get; set; } = null!;
        public int CreditNoteNumberInt { get; set; }
        public DateTime Date { get; set; }
        public decimal Nett { get; set; }
        public decimal Gst { get; set; }
        public decimal Gross { get; set; }
        public decimal AmountReconciled { get; set; }
        public string? CreditNoteDescription { get; set; }
        public string? CreditNoteTypeId { get; set; }
        public Guid? DefaultAccountId { get; set; }
        public string CreditNoteStatusId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public bool? Active { get; set; }
        public Guid AccountNameId { get; set; }
        public decimal AmountRounded { get; set; }

        public virtual Customer AccountName { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
        public virtual PaymentStatusSalesLedger CreditNoteStatus { get; set; } = null!;
        public virtual PaymentType? CreditNoteType { get; set; }
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<CreditNoteReconciliation> CreditNoteReconciliations { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
    }
}
