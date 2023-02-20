using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Note
    {
        public Guid Id { get; set; }
        public string Note1 { get; set; } = null!;
        public string CreatedBy { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public Guid? JobId { get; set; }
        public string? NoteType { get; set; }

        public virtual WebPanelUser CreatedByNavigation { get; set; } = null!;
        public virtual Job? Job { get; set; }
    }
}
