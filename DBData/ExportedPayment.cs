using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ExportedPayment
    {
        public ExportedPayment()
        {
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
        }

        public Guid Id { get; set; }
        public int NumberOfPayments { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? UserName { get; set; }
        public string? IpAddress { get; set; }
        public Guid? CompanyId { get; set; }
        public string? Description { get; set; }
        public Guid? ExportedPaymentId { get; set; }
        public Guid? ExportId { get; set; }

        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
    }
}
