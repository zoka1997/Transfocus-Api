using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class DebtorNote
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? LastContact { get; set; }
        public DateTime? NextContact { get; set; }
        public string? Note { get; set; }
        public bool? Active { get; set; }
        public string? UserId { get; set; }
        public DateTime? Timestamp { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual WebPanelUser? User { get; set; }
    }
}
