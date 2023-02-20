using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SubcontractorPaymentStatus
    {
        public SubcontractorPaymentStatus()
        {
            Payments = new HashSet<Payment>();
            SubcontractorPayments = new HashSet<SubcontractorPayment>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<SubcontractorPayment> SubcontractorPayments { get; set; }
    }
}
