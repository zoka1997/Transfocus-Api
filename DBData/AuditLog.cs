using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AuditLog
    {
        public Guid Id { get; set; }
        public DateTime? TimeStampUtc { get; set; }
        public string? UserId { get; set; }
        public Guid? CompanyId { get; set; }
        public string? TableName { get; set; }
        public string? PrimaryKeyId { get; set; }
        public string? NewValue { get; set; }
        public string? OldValue { get; set; }
        public string? State { get; set; }
        public string? StackTrace { get; set; }
        public string? IpAddress { get; set; }
    }
}
