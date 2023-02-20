using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Payment
    {
        public Payment()
        {
            PaymentItems = new HashSet<PaymentItem>();
        }

        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime Date { get; set; }
        public decimal Gross { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string? PaymentTypeId { get; set; }
        public string? PaymentDescription { get; set; }
        public Guid? PanelInvoiceId { get; set; }
        public string? PaymentNumber { get; set; }
        public Guid PaymentStatusId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual PanelInvoice? PanelInvoice { get; set; }
        public virtual SubcontractorPaymentStatus PaymentStatus { get; set; } = null!;
        public virtual PaymentType? PaymentType { get; set; }
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<PaymentItem> PaymentItems { get; set; }
    }
}
