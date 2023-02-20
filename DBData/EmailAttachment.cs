using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EmailAttachment
    {
        public Guid Id { get; set; }
        public Guid EmailQueueId { get; set; }
        public bool IsExistingFile { get; set; }
        public string Path { get; set; } = null!;
        public string Filename { get; set; } = null!;
        public string Extension { get; set; } = null!;
        public string FileMediaType { get; set; } = null!;
        public DateTime TimeStamp { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual EmailQueue EmailQueue { get; set; } = null!;
    }
}
