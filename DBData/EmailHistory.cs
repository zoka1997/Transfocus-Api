using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EmailHistory
    {
        public Guid Id { get; set; }
        public Guid EmailId { get; set; }
        public string? EmailType { get; set; }
        public string? UserName { get; set; }
        public DateTime? Timestamp { get; set; }
        public Guid? ObjectId { get; set; }

        public virtual EmailQueue Email { get; set; } = null!;
    }
}
