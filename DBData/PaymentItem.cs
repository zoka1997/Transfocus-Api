using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PaymentItem
    {
        public int Id { get; set; }
        public Guid PanelInvoiceId { get; set; }
        public Guid PaymentId { get; set; }
        public decimal Gross { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }

        public virtual PanelInvoice PanelInvoice { get; set; } = null!;
        public virtual Payment Payment { get; set; } = null!;
        public virtual WebPanelUser User { get; set; } = null!;
    }
}
