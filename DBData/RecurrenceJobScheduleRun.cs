using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RecurrenceJobScheduleRun
    {
        public RecurrenceJobScheduleRun()
        {
            RecurrenceJobScheduleRunHistories = new HashSet<RecurrenceJobScheduleRunHistory>();
        }

        public Guid Id { get; set; }
        public Guid RecurrenceJobScheduleId { get; set; }
        public DateTime RunTimeStamp { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public int? WeekNumber { get; set; }
        public int? DayNumber { get; set; }

        public virtual RecurrenceJobSchedule RecurrenceJobSchedule { get; set; } = null!;
        public virtual ICollection<RecurrenceJobScheduleRunHistory> RecurrenceJobScheduleRunHistories { get; set; }
    }
}
