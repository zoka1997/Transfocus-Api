using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EmailQueue
    {
        public EmailQueue()
        {
            EmailAttachments = new HashSet<EmailAttachment>();
            EmailHistories = new HashSet<EmailHistory>();
        }

        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? SenderEmail { get; set; }
        public string RecipientEmail { get; set; } = null!;
        public string? LastError { get; set; }
        public DateTime? LastAttempt { get; set; }
        public int NoOfRetries { get; set; }
        public string? EmailContent { get; set; }
        public string? Subject { get; set; }
        public bool Sent { get; set; }
        public bool HasAttachment { get; set; }
        public string? AttachmentExtension { get; set; }
        public string? AttachmentFileName { get; set; }
        public string? AttachmentFileMediaType { get; set; }
        public string? Cc { get; set; }
        public Guid? CompanyId { get; set; }
        public string? SgmessageId { get; set; }
        public string? Sgstatus { get; set; }
        public Guid? ReferenceId { get; set; }
        public int OpensCount { get; set; }
        public int ClicksCount { get; set; }
        public DateTime? LastEventTime { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<EmailAttachment> EmailAttachments { get; set; }
        public virtual ICollection<EmailHistory> EmailHistories { get; set; }
    }
}
