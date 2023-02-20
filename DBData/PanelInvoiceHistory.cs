using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoiceHistory
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string? Description { get; set; }
        public Guid PanelInvoiceId { get; set; }
        public string? InvoiceStatusId { get; set; }

        public virtual PanelInvoiceStatus? InvoiceStatus { get; set; }
        public virtual PanelInvoice PanelInvoice { get; set; } = null!;
    }
}
