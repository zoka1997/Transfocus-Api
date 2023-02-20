using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ImportedCustomersForUpdate
    {
        public int Id { get; set; }
        public Guid? CustomerId { get; set; }
        public Guid? CompanyId { get; set; }
        public string? Code { get; set; }
        public string? Abn { get; set; }
        public string? AccountCode { get; set; }
        public bool? Active { get; set; }
        public bool? CanEditAdresses { get; set; }
        public bool? CanEditProducts { get; set; }
        public string? Name { get; set; }
        public bool? ShowInvoice { get; set; }
        public bool? ExportedToFoxPro { get; set; }
        public int? CountryId { get; set; }
        public string? InvoiceDeliveryMethodId { get; set; }
        public string? InvoiceFrequencyId { get; set; }
        public string? InvoicingGroupingId { get; set; }
        public string? PaymentTermsId { get; set; }
        public bool? PaymentTermsEop { get; set; }
        public Guid? PostalLocationId { get; set; }
        public Guid? GstcodeId { get; set; }
        public decimal? TaxRate { get; set; }
        public bool? UseInvoiceExport { get; set; }
        public bool? InvoiceAttachPod { get; set; }
        public bool? RequirePod { get; set; }
        public bool? RequireCustomerPodpaperwork { get; set; }
        public bool? RequirePodbeforeInvoicing { get; set; }
        public string? AccountName { get; set; }
        public bool? IsAccount { get; set; }
        public string? CustomerSendInvoicesTo { get; set; }
        public Guid? AccountingSystemInstanceId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? Bpayreference { get; set; }
        public string? UserId { get; set; }
        public string? CustomerCodeNew { get; set; }
        public int? InvoiceTemplateId { get; set; }
        public Guid? DefaultPricingScheduleTypeId { get; set; }
        public string? TradingName { get; set; }
    }
}
