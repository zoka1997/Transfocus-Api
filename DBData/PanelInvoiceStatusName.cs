using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoiceStatusName
    {
        public int Id { get; set; }
        public string PanelInvoiceStatusId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string AccountingSystemId { get; set; } = null!;
        public string InterfaceTypeId { get; set; } = null!;

        public virtual AccountingSystem AccountingSystem { get; set; } = null!;
        public virtual InterfaceType InterfaceType { get; set; } = null!;
        public virtual PanelInvoiceStatus PanelInvoiceStatus { get; set; } = null!;
    }
}
