using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobCancelResponse
    {
        public JobCancelResponse()
        {
            Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public Guid JobCancelReasonId { get; set; }
        public string Notes { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public DateTime Timestamp { get; set; }

        public virtual JobCancelReason JobCancelReason { get; set; } = null!;
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
