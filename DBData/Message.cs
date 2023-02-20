using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Message
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid ConversationId { get; set; }
        public DateTime Timestamp { get; set; }
        public string Text { get; set; } = null!;
        public bool Acknowledged { get; set; }
        public bool MessageRead { get; set; }
        public DateTime? TimestampAcknowledged { get; set; }
        public DateTime? TimestampRead { get; set; }

        public virtual ConversationParticipant Conversation { get; set; } = null!;
        public virtual User Sender { get; set; } = null!;
    }
}
