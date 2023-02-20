using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PaymentSalesLedger
    {
        public PaymentSalesLedger()
        {
            PaymentReconciliations = new HashSet<PaymentReconciliation>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string PaymentNumber { get; set; } = null!;
        public int PaymentNumberInt { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountReconciled { get; set; }
        public string? PaymentDescription { get; set; }
        public string? PaymentTypeId { get; set; }
        public Guid DefaultAccountId { get; set; }
        public string PaymentStatusId { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public bool IsReversal { get; set; }
        public bool? Active { get; set; }
        public Guid AccountNameId { get; set; }
        public Guid? ReversedPaymentId { get; set; }
        public bool IsStripePayment { get; set; }
        public string? StripePaymentId { get; set; }
        public string? StripeReceiptUrl { get; set; }
        public decimal? OriginalAmount { get; set; }
        public decimal AmountRounded { get; set; }
        public bool Exported { get; set; }
        public DateTime? ExportedTimestamp { get; set; }
        public Guid? ExportedPaymentId { get; set; }

        public virtual Customer AccountName { get; set; } = null!;
        public virtual Company Company { get; set; } = null!;
        public virtual DefaultAccount DefaultAccount { get; set; } = null!;
        public virtual ExportedPayment? ExportedPayment { get; set; }
        public virtual PaymentStatusSalesLedger PaymentStatus { get; set; } = null!;
        public virtual PaymentType? PaymentType { get; set; }
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<PaymentReconciliation> PaymentReconciliations { get; set; }
    }
}
