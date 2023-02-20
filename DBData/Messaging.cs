using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Messaging
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid? RecipientId { get; set; }
        public string MessageText { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public bool IsAcknowledged { get; set; }
        public bool IsRead { get; set; }
        public DateTime? TimestampAcknowledged { get; set; }
        public DateTime? TimestampRead { get; set; }
        public bool DeletedSender { get; set; }
        public bool DeletedRecipient { get; set; }

        public virtual User? Recipient { get; set; }
        public virtual User Sender { get; set; } = null!;
    }
}
