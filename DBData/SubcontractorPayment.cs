using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SubcontractorPayment
    {
        public Guid Id { get; set; }
        public Guid? JobLegId { get; set; }
        public DateTime Date { get; set; }
        public decimal GrossAmount { get; set; }
        public Guid UserId { get; set; }
        public DateTime Timestamp { get; set; }
        public string PaymentNumber { get; set; } = null!;
        public string PaymentDescription { get; set; } = null!;
        public Guid SubcontractorId { get; set; }
        public Guid SubcontractorPaymentStatusId { get; set; }

        public virtual JobLeg? JobLeg { get; set; }
        public virtual Subcontractor Subcontractor { get; set; } = null!;
        public virtual SubcontractorPaymentStatus SubcontractorPaymentStatus { get; set; } = null!;
        public virtual AspnetUser User { get; set; } = null!;
    }
}
