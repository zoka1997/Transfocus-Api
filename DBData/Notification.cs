using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Notification
    {
        public Guid Id { get; set; }
        public Guid? SenderUserId { get; set; }
        public Guid? ReceiverUserId { get; set; }
        public Guid? ManifestId { get; set; }
        public DateTime? Acknowledged { get; set; }
        public string Type { get; set; } = null!;
        public bool Sync { get; set; }
        public string? Message { get; set; }
        public string? Title { get; set; }
        public string? Sound { get; set; }
        public string? Data { get; set; }
        public DateTime? AcknowledgeSentDateTime { get; set; }

        public virtual Manifest? Manifest { get; set; }
    }
}
