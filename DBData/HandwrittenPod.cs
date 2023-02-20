using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class HandwrittenPod
    {
        public Guid Id { get; set; }
        public Guid? JobLegId { get; set; }
        public DateTime Timestamp { get; set; }
        public string FileExtension { get; set; } = null!;
        public Guid? JobId { get; set; }
        public bool IsManuallyUploaded { get; set; }
        public string? Type { get; set; }
        public bool? Active { get; set; }
        public bool IsScanned { get; set; }
        public string? Name { get; set; }
        public int? Size { get; set; }
        public bool EdiStatus { get; set; }

        public virtual Job? Job { get; set; }
        public virtual JobLeg? JobLeg { get; set; }
    }
}
