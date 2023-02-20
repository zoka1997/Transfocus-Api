using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InvoiceNumberTemp
    {
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public int InvoiceNumber { get; set; }
    }
}
