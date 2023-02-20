using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RecurrenceJobScheduleRunHistory
    {
        public Guid Id { get; set; }
        public Guid RecurrenceJobScheduleRunId { get; set; }
        public Guid SourceJobId { get; set; }
        public Guid NewJobId { get; set; }
        public DateTime NewJobDate { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Detail { get; set; }

        public virtual Job NewJob { get; set; } = null!;
        public virtual RecurrenceJobScheduleRun RecurrenceJobScheduleRun { get; set; } = null!;
        public virtual Job SourceJob { get; set; } = null!;
    }
}
