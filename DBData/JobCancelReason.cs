using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobCancelReason
    {
        public JobCancelReason()
        {
            JobCancelResponses = new HashSet<JobCancelResponse>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<JobCancelResponse> JobCancelResponses { get; set; }
    }
}
