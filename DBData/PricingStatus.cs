using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingStatus
    {
        public PricingStatus()
        {
            Jobs = new HashSet<Job>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
