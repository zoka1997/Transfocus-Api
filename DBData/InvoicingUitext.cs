using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InvoicingUitext
    {
        public int Id { get; set; }
        public string Text { get; set; } = null!;
        public string Uielement { get; set; } = null!;
        public string? AccountingSystemId { get; set; }
        public string? InterfaceTypeId { get; set; }

        public virtual AccountingSystem? AccountingSystem { get; set; }
        public virtual InterfaceType? InterfaceType { get; set; }
    }
}
