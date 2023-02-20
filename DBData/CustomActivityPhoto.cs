using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomActivityPhoto
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public DateTime? Timestamp { get; set; }
        public Guid? ActivityId { get; set; }
    }
}
