using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoiceStatus
    {
        public PanelInvoiceStatus()
        {
            PanelInvoiceHistories = new HashSet<PanelInvoiceHistory>();
            PanelInvoiceStatusNames = new HashSet<PanelInvoiceStatusName>();
            PanelInvoices = new HashSet<PanelInvoice>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }

        public virtual ICollection<PanelInvoiceHistory> PanelInvoiceHistories { get; set; }
        public virtual ICollection<PanelInvoiceStatusName> PanelInvoiceStatusNames { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
    }
}
