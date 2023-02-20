using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AutomaticEdilog
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? FormatId { get; set; }
        public string FileName { get; set; } = null!;
        public string LogFileUrl { get; set; } = null!;
        public DateTime ProcessedTimeStamp { get; set; }
        public bool Success { get; set; }
        public string? Description { get; set; }
        public string FileUrl { get; set; } = null!;
        public int? ImportTypeId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual JobImportMode? Format { get; set; }
        public virtual ImportType? ImportType { get; set; }
    }
}
