using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Invoice
    {
        public Invoice()
        {
            Jobs = new HashSet<Job>();
        }

        public Guid Id { get; set; }
        public DateTime? Date { get; set; }
        public string? Type { get; set; }
        public string? BatchNumber { get; set; }
        public string? Description { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Outstand { get; set; }
        public decimal? Gst { get; set; }
        public decimal? Nett { get; set; }
        public decimal? Gross { get; set; }
        public decimal? Debit { get; set; }
        public decimal? Credit { get; set; }
        public decimal? GstRate { get; set; }
        public DateTime? EntDate { get; set; }
        public DateTime? PayDate { get; set; }
        public Guid? CustomerId { get; set; }
        public string? StatusId { get; set; }
        public int Seq { get; set; }
        public Guid CompanyId { get; set; }
        public string ImportedBy { get; set; } = null!;

        public virtual Company Company { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual WebPanelUser ImportedByNavigation { get; set; } = null!;
        public virtual InvoiceStatus? Status { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
