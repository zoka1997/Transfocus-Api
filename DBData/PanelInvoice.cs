using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PanelInvoice
    {
        public PanelInvoice()
        {
            CreditNoteReconciliations = new HashSet<CreditNoteReconciliation>();
            InvoiceSalesJournalExportedInvoices = new HashSet<InvoiceSalesJournalExportedInvoice>();
            JobLegs = new HashSet<JobLeg>();
            Jobs = new HashSet<Job>();
            Manifests = new HashSet<Manifest>();
            PanelInvoiceDeletedJobs = new HashSet<PanelInvoiceDeletedJob>();
            PanelInvoiceHistories = new HashSet<PanelInvoiceHistory>();
            PaymentItems = new HashSet<PaymentItem>();
            PaymentReconciliations = new HashSet<PaymentReconciliation>();
            Payments = new HashSet<Payment>();
            PricingInvoices = new HashSet<PricingInvoice>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string UserId { get; set; } = null!;
        public Guid? CustomerId { get; set; }
        public string InvoiceNumber { get; set; } = null!;
        public DateTime InvoiceDate { get; set; }
        public DateTime? DueDate { get; set; }
        public decimal Gst { get; set; }
        public decimal Nett { get; set; }
        public decimal Gross { get; set; }
        public decimal? GstRate { get; set; }
        public Guid? InvoiceBatchId { get; set; }
        public string PanelInvoiceStatusId { get; set; } = null!;
        public bool HasJobs { get; set; }
        public bool? Active { get; set; }
        public int InvoiceNumberInt { get; set; }
        public string? AccountRef { get; set; }
        public string? InvoiceDescription { get; set; }
        public string? AccountingSystemId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? SubcontractorId { get; set; }
        public Guid? AccountingSystemInstanceId { get; set; }
        public int SpanumberInt { get; set; }
        public Guid? SpabatchId { get; set; }
        public string PanelInvoiceTypeId { get; set; } = null!;
        public bool Exported { get; set; }
        public Guid? CredNoteSalesLedger { get; set; }
        public string? CostCentre { get; set; }

        public virtual AccountingSystemInstance? AccountingSystemInstance { get; set; }
        public virtual Company Company { get; set; } = null!;
        public virtual CreditNoteSalesLedger? CredNoteSalesLedgerNavigation { get; set; }
        public virtual Customer? Customer { get; set; }
        public virtual InvoiceBatch? InvoiceBatch { get; set; }
        public virtual PanelInvoiceStatus PanelInvoiceStatus { get; set; } = null!;
        public virtual PanelInvoiceType PanelInvoiceType { get; set; } = null!;
        public virtual Spabatch? Spabatch { get; set; }
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual WebPanelUser User { get; set; } = null!;
        public virtual ICollection<CreditNoteReconciliation> CreditNoteReconciliations { get; set; }
        public virtual ICollection<InvoiceSalesJournalExportedInvoice> InvoiceSalesJournalExportedInvoices { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<PanelInvoiceDeletedJob> PanelInvoiceDeletedJobs { get; set; }
        public virtual ICollection<PanelInvoiceHistory> PanelInvoiceHistories { get; set; }
        public virtual ICollection<PaymentItem> PaymentItems { get; set; }
        public virtual ICollection<PaymentReconciliation> PaymentReconciliations { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PricingInvoice> PricingInvoices { get; set; }
    }
}
