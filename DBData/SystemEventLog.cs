using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SystemEventLog
    {
        public Guid Id { get; set; }
        public string Source { get; set; } = null!;
        public string? Description { get; set; }
        public DateTime Timestamp { get; set; }
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }
    }
}
