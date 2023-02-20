using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ReportsApiauth
    {
        public int Id { get; set; }
        public string UserId { get; set; } = null!;
        public Guid CompanyId { get; set; }
        public Guid Token { get; set; }
        public bool Active { get; set; }
        public DateTime? ExpiryDate { get; set; }

        public virtual WebPanelUser User { get; set; } = null!;
    }
}
