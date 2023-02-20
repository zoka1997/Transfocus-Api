using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoiceView
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public Guid? CustomerId { get; set; }
        public string Customer { get; set; } = null!;
        public string? CustomerEmail { get; set; }
        public string AccountName { get; set; } = null!;
        public decimal Nett { get; set; }
        public decimal Gst { get; set; }
        public decimal Gross { get; set; }
        public decimal? DueAmount { get; set; }
        public string StatusId { get; set; } = null!;
        public string? Status { get; set; }
        public string? Color { get; set; }
        public string? LastStatusId { get; set; }
        public string? LastStatus { get; set; }
        public string? LastStatusColor { get; set; }
        public DateTime? LastStatusDateTime { get; set; }
        public DateTime Date { get; set; }
        public DateTime? DueDate { get; set; }
        public Guid? BatchId { get; set; }
        public int? BatchNumber { get; set; }
        public int? NumberOfJobs { get; set; }
        public string? InvoiceDeliveryMethodId { get; set; }
        public string? InvoiceDeliveryMethod { get; set; }
        public string CustomerContactEmail { get; set; } = null!;
        public bool? Sent { get; set; }
        public string? AccountRef { get; set; }
        public string? InvoiceDescription { get; set; }
        public int? InvoiceReceiversCount { get; set; }
        public string? CustomerAccountingSystem { get; set; }
        public string? InvoiceAccountingSystem { get; set; }
        public string? InvoiceXeroId { get; set; }
        public int IsEditable { get; set; }
        public bool Active { get; set; }
        public string? InvoiceType { get; set; }
        public bool Exported { get; set; }
    }
}
