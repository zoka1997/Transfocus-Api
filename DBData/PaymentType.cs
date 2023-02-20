using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PaymentType
    {
        public PaymentType()
        {
            CreditNoteSalesLedgers = new HashSet<CreditNoteSalesLedger>();
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
            Payments = new HashSet<Payment>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public bool? AvailableToSalesLedger { get; set; }

        public virtual ICollection<CreditNoteSalesLedger> CreditNoteSalesLedgers { get; set; }
        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
    }
}
