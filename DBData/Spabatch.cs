using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Spabatch
    {
        public Spabatch()
        {
            PanelInvoices = new HashSet<PanelInvoice>();
        }

        public Guid Id { get; set; }
        public int BatchNumber { get; set; }
        public DateTime Timestamp { get; set; }
        public string UserId { get; set; } = null!;
        public DateTime Date { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
    }
}
