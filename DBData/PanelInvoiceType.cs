using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoiceType
    {
        public PanelInvoiceType()
        {
            PanelInvoices = new HashSet<PanelInvoice>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
    }
}
