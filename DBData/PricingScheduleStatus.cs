using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingScheduleStatus
    {
        public PricingScheduleStatus()
        {
            PricingSchedules = new HashSet<PricingSchedule>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<PricingSchedule> PricingSchedules { get; set; }
    }
}
