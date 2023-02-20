using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ReportCompanyList
    {
        public Guid Id { get; set; }
        public int ReportId { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Report Report { get; set; } = null!;
    }
}
