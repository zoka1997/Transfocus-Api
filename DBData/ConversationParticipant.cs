using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ConversationParticipant
    {
        public ConversationParticipant()
        {
            Messages = new HashSet<Message>();
        }

        public Guid Id { get; set; }
        public Guid ConversationId { get; set; }
        public Guid ParticipantId { get; set; }

        public virtual User Participant { get; set; } = null!;
        public virtual ICollection<Message> Messages { get; set; }
    }
}
