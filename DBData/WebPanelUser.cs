using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class WebPanelUser
    {
        public WebPanelUser()
        {
            CreditNoteSalesLedgers = new HashSet<CreditNoteSalesLedger>();
            CustomPages = new HashSet<CustomPage>();
            CustomerNotes = new HashSet<CustomerNote>();
            CustomerPricingNotes = new HashSet<CustomerPricingNote>();
            DebtorNotes = new HashSet<DebtorNote>();
            Edilogs = new HashSet<Edilog>();
            GridStateDefaults = new HashSet<GridStateDefault>();
            GridStateProfiles = new HashSet<GridStateProfile>();
            InvoiceBatches = new HashSet<InvoiceBatch>();
            Invoices = new HashSet<Invoice>();
            JobCancelResponses = new HashSet<JobCancelResponse>();
            JobCodes = new HashSet<JobCode>();
            JobDocuments = new HashSet<JobDocument>();
            JobLegPallets = new HashSet<JobLegPallet>();
            JobModifiedByNavigations = new HashSet<Job>();
            JobPricings = new HashSet<JobPricing>();
            JobUsers = new HashSet<Job>();
            ManifestHistories = new HashSet<ManifestHistory>();
            Notes = new HashSet<Note>();
            PanelInvoiceDeletedJobs = new HashSet<PanelInvoiceDeletedJob>();
            PanelInvoices = new HashSet<PanelInvoice>();
            PaymentItems = new HashSet<PaymentItem>();
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
            Payments = new HashSet<Payment>();
            Pricings = new HashSet<Pricing>();
            RangePricings = new HashSet<RangePricing>();
            ReportsApiauths = new HashSet<ReportsApiauth>();
            Spabatches = new HashSet<Spabatch>();
            WebPanelUserCustomers = new HashSet<WebPanelUserCustomer>();
            Zones = new HashSet<Zone>();
        }

        public string Id { get; set; } = null!;
        public Guid CompanyId { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Email { get; set; } = null!;
        public string? Telephone1 { get; set; }
        public string? Telephone2 { get; set; }
        public string? Address { get; set; }
        public bool Active { get; set; }
        public bool HasPhoto { get; set; }
        public int Type { get; set; }
        public Guid? DepotId { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? SubcontractorId { get; set; }
        public bool? ReceiveSummaryEmail { get; set; }
        public int? UserGroupId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual Location? Depot { get; set; }
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual WebPanelUsersType TypeNavigation { get; set; } = null!;
        public virtual UserGroup? UserGroup { get; set; }
        public virtual ICollection<CreditNoteSalesLedger> CreditNoteSalesLedgers { get; set; }
        public virtual ICollection<CustomPage> CustomPages { get; set; }
        public virtual ICollection<CustomerNote> CustomerNotes { get; set; }
        public virtual ICollection<CustomerPricingNote> CustomerPricingNotes { get; set; }
        public virtual ICollection<DebtorNote> DebtorNotes { get; set; }
        public virtual ICollection<Edilog> Edilogs { get; set; }
        public virtual ICollection<GridStateDefault> GridStateDefaults { get; set; }
        public virtual ICollection<GridStateProfile> GridStateProfiles { get; set; }
        public virtual ICollection<InvoiceBatch> InvoiceBatches { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<JobCancelResponse> JobCancelResponses { get; set; }
        public virtual ICollection<JobCode> JobCodes { get; set; }
        public virtual ICollection<JobDocument> JobDocuments { get; set; }
        public virtual ICollection<JobLegPallet> JobLegPallets { get; set; }
        public virtual ICollection<Job> JobModifiedByNavigations { get; set; }
        public virtual ICollection<JobPricing> JobPricings { get; set; }
        public virtual ICollection<Job> JobUsers { get; set; }
        public virtual ICollection<ManifestHistory> ManifestHistories { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<PanelInvoiceDeletedJob> PanelInvoiceDeletedJobs { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
        public virtual ICollection<PaymentItem> PaymentItems { get; set; }
        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
        public virtual ICollection<RangePricing> RangePricings { get; set; }
        public virtual ICollection<ReportsApiauth> ReportsApiauths { get; set; }
        public virtual ICollection<Spabatch> Spabatches { get; set; }
        public virtual ICollection<WebPanelUserCustomer> WebPanelUserCustomers { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
    }
}
