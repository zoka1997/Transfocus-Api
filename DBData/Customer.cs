using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Customer
    {
        public Customer()
        {
            ConsolidatedConsignmentNotes = new HashSet<ConsolidatedConsignmentNote>();
            CreditNoteSalesLedgers = new HashSet<CreditNoteSalesLedger>();
            CustomActivities = new HashSet<CustomActivity>();
            CustomerContacts = new HashSet<CustomerContact>();
            CustomerLocations = new HashSet<CustomerLocation>();
            CustomerNotes = new HashSet<CustomerNote>();
            CustomerPricingNotes = new HashSet<CustomerPricingNote>();
            CustomerProducts = new HashSet<CustomerProduct>();
            DebtorNotes = new HashSet<DebtorNote>();
            Invoices = new HashSet<Invoice>();
            JobCustomers = new HashSet<Job>();
            JobLegs = new HashSet<JobLeg>();
            JobProductOwnerNavigations = new HashSet<Job>();
            JobSenderRecipientDefaults = new HashSet<JobSenderRecipientDefault>();
            LocationCustomers = new HashSet<Location>();
            LocationDefaultCustomers = new HashSet<Location>();
            PalletAccounts = new HashSet<PalletAccount>();
            PanelInvoices = new HashSet<PanelInvoice>();
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
            Payments = new HashSet<Payment>();
            PersonalCustomerLocations = new HashSet<PersonalCustomerLocation>();
            PricingScheduleCustomers = new HashSet<PricingScheduleCustomer>();
            Pricings = new HashSet<Pricing>();
            Products = new HashSet<Product>();
            RangePricings = new HashSet<RangePricing>();
            ServiceCodeProducts = new HashSet<ServiceCodeProduct>();
            ServiceLanes = new HashSet<ServiceLane>();
            WebPanelUserCustomers = new HashSet<WebPanelUserCustomer>();
            WebPanelUsers = new HashSet<WebPanelUser>();
            Zones = new HashSet<Zone>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? AccountCode { get; set; }
        public string? Abn { get; set; }
        public string? ContactName { get; set; }
        public string? ContactPhone { get; set; }
        public string? ContactEmail { get; set; }
        public Guid CompanyId { get; set; }
        public bool? Active { get; set; }
        public Guid? DefaultLocation { get; set; }
        public string? DropboxFolder { get; set; }
        public bool? CanEditAdresses { get; set; }
        public bool? CanEditProducts { get; set; }
        public int CountryId { get; set; }
        public bool ShowInvoice { get; set; }
        public string? FoxProStatus { get; set; }
        public bool ExportedToFoxPro { get; set; }
        public string? InvoicingGroupingId { get; set; }
        public string? InvoiceDeliveryMethodId { get; set; }
        public string? PaymentTermsId { get; set; }
        public bool PaymentTermsEop { get; set; }
        public string? InvoiceFrequencyId { get; set; }
        public Guid? PostalLocationId { get; set; }
        public int? InvoiceTemplateId { get; set; }
        public decimal? TaxRate { get; set; }
        public Guid? GstcodeId { get; set; }
        public string? JobWeightType { get; set; }
        public bool UseInvoiceExport { get; set; }
        public Guid? ExportInvoiceTemplateId { get; set; }
        public bool InvoiceAttachPod { get; set; }
        public string? BookingType { get; set; }
        public bool? RequirePod { get; set; }
        public bool? RequireCustomerPodpaperwork { get; set; }
        public bool? RequirePodbeforeInvoicing { get; set; }
        public string AccountName { get; set; } = null!;
        public bool IsAccount { get; set; }
        public string CustomerSendInvoicesTo { get; set; } = null!;
        public Guid? AccountingSystemInstanceId { get; set; }
        public string? AccountingSystemId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Bpayreference { get; set; }
        public Guid? DefaultPricingScheduleTypeId { get; set; }
        public Guid? XeroId { get; set; }
        public byte? PricingScheduleSelectionLogic { get; set; }
        public DateTime? CreationDate { get; set; }
        public string? InvoiceReference { get; set; }
        public string? Alias { get; set; }
        public bool ShowPriceOnConsignment { get; set; }
        public string? CustomerCodeNew { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? Group2Id { get; set; }
        public string? TradingName { get; set; }
        public string? AccountSystemName { get; set; }

        public virtual AccountingSystemInstance? AccountingSystemInstance { get; set; }
        public virtual Company Company { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual PricingScheduleType? DefaultPricingScheduleType { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual Gstcode? Gstcode { get; set; }
        public virtual InvoiceDeliveryMethod? InvoiceDeliveryMethod { get; set; }
        public virtual InvoicingFrequency? InvoiceFrequency { get; set; }
        public virtual Report? InvoiceTemplate { get; set; }
        public virtual InvoicingGrouping? InvoicingGrouping { get; set; }
        public virtual PaymentTerm? PaymentTerms { get; set; }
        public virtual Location? PostalLocation { get; set; }
        public virtual ICollection<ConsolidatedConsignmentNote> ConsolidatedConsignmentNotes { get; set; }
        public virtual ICollection<CreditNoteSalesLedger> CreditNoteSalesLedgers { get; set; }
        public virtual ICollection<CustomActivity> CustomActivities { get; set; }
        public virtual ICollection<CustomerContact> CustomerContacts { get; set; }
        public virtual ICollection<CustomerLocation> CustomerLocations { get; set; }
        public virtual ICollection<CustomerNote> CustomerNotes { get; set; }
        public virtual ICollection<CustomerPricingNote> CustomerPricingNotes { get; set; }
        public virtual ICollection<CustomerProduct> CustomerProducts { get; set; }
        public virtual ICollection<DebtorNote> DebtorNotes { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<Job> JobCustomers { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Job> JobProductOwnerNavigations { get; set; }
        public virtual ICollection<JobSenderRecipientDefault> JobSenderRecipientDefaults { get; set; }
        public virtual ICollection<Location> LocationCustomers { get; set; }
        public virtual ICollection<Location> LocationDefaultCustomers { get; set; }
        public virtual ICollection<PalletAccount> PalletAccounts { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
        public virtual ICollection<Payment> Payments { get; set; }
        public virtual ICollection<PersonalCustomerLocation> PersonalCustomerLocations { get; set; }
        public virtual ICollection<PricingScheduleCustomer> PricingScheduleCustomers { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<RangePricing> RangePricings { get; set; }
        public virtual ICollection<ServiceCodeProduct> ServiceCodeProducts { get; set; }
        public virtual ICollection<ServiceLane> ServiceLanes { get; set; }
        public virtual ICollection<WebPanelUserCustomer> WebPanelUserCustomers { get; set; }
        public virtual ICollection<WebPanelUser> WebPanelUsers { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
    }
}
