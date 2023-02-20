using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoiceDeletedJob
    {
        public int Id { get; set; }
        public Guid PanelInvoiceId { get; set; }
        public Guid JobId { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserId { get; set; } = null!;

        public virtual Job Job { get; set; } = null!;
        public virtual PanelInvoice PanelInvoice { get; set; } = null!;
        public virtual WebPanelUser User { get; set; } = null!;
    }
}
