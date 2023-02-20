using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RecurrenceJobList
    {
        public Guid Id { get; set; }
        public Guid RecurrenceJobScheduleId { get; set; }
        public Guid SourceJobId { get; set; }
        public DateTime TimeStamp { get; set; }

        public virtual RecurrenceJobSchedule RecurrenceJobSchedule { get; set; } = null!;
        public virtual Job SourceJob { get; set; } = null!;
    }
}
