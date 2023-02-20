using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAssetAttachment
    {
        public Guid Id { get; set; }
        public Guid FleetAssetId { get; set; }
        public string Path { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public string? OriginalFilename { get; set; }
        public int? Size { get; set; }
        public string? FileType { get; set; }
        public bool IsPrimary { get; set; }
        public string? UploadedBy { get; set; }
        public DateTime Timestamp { get; set; }
        public string? Description { get; set; }

        public virtual FleetAsset FleetAsset { get; set; } = null!;
    }
}
