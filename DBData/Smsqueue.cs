using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Smsqueue
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Smsto { get; set; } = null!;
        public string? Smsbody { get; set; }
        public bool Sent { get; set; }
        public string? Smsid { get; set; }
        public string? LastError { get; set; }
        public DateTime? LastAttempt { get; set; }
        public int NoOfRetries { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
