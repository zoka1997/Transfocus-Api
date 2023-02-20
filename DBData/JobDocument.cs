using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobDocument
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public int JobDocumentTypeId { get; set; }
        public string? Path { get; set; }
        public string? OriginalFilename { get; set; }
        public int? Size { get; set; }
        public string Extension { get; set; } = null!;
        public string MimeType { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public string? UploadedBy { get; set; }

        public virtual Job Job { get; set; } = null!;
        public virtual JobDocumentType JobDocumentType { get; set; } = null!;
        public virtual WebPanelUser? UploadedByNavigation { get; set; }
    }
}
