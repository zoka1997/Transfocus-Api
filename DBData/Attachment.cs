using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Attachment
    {
        public Guid Id { get; set; }
        public string UploadedBy { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public string FileName { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public string? FileType { get; set; }
        public Guid? JobId { get; set; }
        public int? Size { get; set; }

        public virtual Job? Job { get; set; }
    }
}
