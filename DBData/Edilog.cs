using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Edilog
    {
        public Edilog()
        {
            EdilogDetails = new HashSet<EdilogDetail>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string FileName { get; set; } = null!;
        public string ModifiedBy { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public string? EventLog { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual WebPanelUser ModifiedByNavigation { get; set; } = null!;
        public virtual ICollection<EdilogDetail> EdilogDetails { get; set; }
    }
}
