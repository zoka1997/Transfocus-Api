using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ConsignmentReportView
    {
        public string JobNumber { get; set; } = null!;
        public string JobReference { get; set; } = null!;
        public string ConsignmentNumber { get; set; } = null!;
        public string ConsignmentReference { get; set; } = null!;
        public string? Instructions { get; set; }
        public string? SignedBy { get; set; }
        public bool Signed { get; set; }
        public DateTime Timestamp { get; set; }
        public string TripStatusId { get; set; } = null!;
        public string? PodstatusId { get; set; }
        public string? PodexceptionId { get; set; }
        public string JobLegTypeId { get; set; } = null!;
        public string JobTypeId { get; set; } = null!;
        public string JobKindId { get; set; } = null!;
        public bool UseScanLoad { get; set; }
        public bool UseScanOff { get; set; }
        public string? SenderNote { get; set; }
        public string? SenderPhone { get; set; }
        public string? RecepientNote { get; set; }
        public string? RecepientPhone { get; set; }
        public string? WorkflowId { get; set; }
        public string? WorkflowSubId { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? ArrivedSenderTimestamp { get; set; }
        public DateTime? ArrivedReceiverTimestamp { get; set; }
        public DateTime? DepartedSenderTimestamp { get; set; }
        public DateTime? DepartedReceiverTimestamp { get; set; }
        public string? PodexceptionNote { get; set; }
        public bool Acknowledged { get; set; }
        public DateTime? TimestampAcknowledged { get; set; }
        public string Name { get; set; } = null!;
        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        public string Expr1 { get; set; } = null!;
        public string Expr2 { get; set; } = null!;
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Address { get; set; }
        public Guid Expr3 { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
    }
}
