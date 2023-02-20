using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PaymentStatusSalesLedger
    {
        public PaymentStatusSalesLedger()
        {
            CreditNoteSalesLedgers = new HashSet<CreditNoteSalesLedger>();
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<CreditNoteSalesLedger> CreditNoteSalesLedgers { get; set; }
        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
    }
}
