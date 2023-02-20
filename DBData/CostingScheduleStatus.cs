using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CostingScheduleStatus
    {
        public CostingScheduleStatus()
        {
            CostingSchedules = new HashSet<CostingSchedule>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<CostingSchedule> CostingSchedules { get; set; }
    }
}
