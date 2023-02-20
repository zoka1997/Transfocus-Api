using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RecurrenceJobSchedule
    {
        public RecurrenceJobSchedule()
        {
            RecurrenceJobLists = new HashSet<RecurrenceJobList>();
            RecurrenceJobScheduleRuns = new HashSet<RecurrenceJobScheduleRun>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string Name { get; set; } = null!;
        public string? Detail { get; set; }
        public DateTime ScheduleStart { get; set; }
        public DateTime? ScheduleEnd { get; set; }
        public bool Active { get; set; }
        public string Frequency { get; set; } = null!;
        public string? FrequencyDetail { get; set; }
        public int Interval { get; set; }
        public string? GenerateForWeekDays { get; set; }
        public bool CopyJobReferences { get; set; }
        public bool CopyJobProducts { get; set; }
        public bool CopyJobLegs { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ICollection<RecurrenceJobList> RecurrenceJobLists { get; set; }
        public virtual ICollection<RecurrenceJobScheduleRun> RecurrenceJobScheduleRuns { get; set; }
    }
}
