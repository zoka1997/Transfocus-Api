using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EnquiryView
    {
        public Guid JobId { get; set; }
        public string? UnitRates { get; set; }
        public Guid? CompanyId { get; set; }
        public string JobNumber { get; set; } = null!;
        public long? JobNumberNumeral { get; set; }
        public DateTime? JobDate { get; set; }
        public DateTime? JobDateEntered { get; set; }
        public string? JobEnteredBy { get; set; }
        public Guid? CustomerId { get; set; }
        public string? Customer { get; set; }
        public string? CustomerAccount { get; set; }
        public string? CustomerEntity { get; set; }
        public string? CustomerInvoicingFrequency { get; set; }
        public string? JobDescription { get; set; }
        public Guid? InvoiceId { get; set; }
        public bool? IsInvoiceActive { get; set; }
        public string? Reference1 { get; set; }
        public string? Reference2 { get; set; }
        public string? Reference3 { get; set; }
        public string? Reference4 { get; set; }
        public string? Reference5 { get; set; }
        public string? Reference6 { get; set; }
        public string? Reference7 { get; set; }
        public string? Reference8 { get; set; }
        public string? Reference9 { get; set; }
        public string? Reference10 { get; set; }
        public string? JobGroup1 { get; set; }
        public string? JobGroup2 { get; set; }
        public bool Active { get; set; }
        public string JobContact { get; set; } = null!;
        public string? JobService { get; set; }
        public Guid? ServiceCodeId { get; set; }
        public string? JobKindId { get; set; }
        public bool BackToDepot { get; set; }
        public decimal Waiting { get; set; }
        public bool InvoicingOnly { get; set; }
        public Guid? DepotId { get; set; }
        public string? JobDepot { get; set; }
        public DateTime? JobReady { get; set; }
        public decimal? JobReadyFromCustomOffset { get; set; }
        public DateTime? JobRequired { get; set; }
        public decimal? JobRequiredCustomOffset { get; set; }
        public string JobImportTypeId { get; set; } = null!;
        public string? JobStatusId { get; set; }
        public string? JobStatus { get; set; }
        public string? JobStatusColor { get; set; }
        public string? JobPriceStatusId { get; set; }
        public string? JobPriceStatus { get; set; }
        public string? JobPriceStatusColor { get; set; }
        public string? JobProductOwner { get; set; }
        public string? JobBookingType { get; set; }
        public string? JobWeightType { get; set; }
        public decimal JobQuantity { get; set; }
        public decimal JobPallets { get; set; }
        public decimal JobWeight { get; set; }
        public decimal JobCubicWeight { get; set; }
        public decimal JobCubic { get; set; }
        public decimal JobSpace { get; set; }
        public decimal JobKms { get; set; }
        public decimal JobHours { get; set; }
        public decimal JobWaiting { get; set; }
        public int JobDrops { get; set; }
        public decimal JobPrice { get; set; }
        public bool? AutoPriceComplete { get; set; }
        public decimal JobCost { get; set; }
        public decimal JobExpense { get; set; }
        public decimal? JobProfit { get; set; }
        public decimal? JobProfitPercentage { get; set; }
        public Guid? SenderId { get; set; }
        public string? SenderName { get; set; }
        public string? SenderLocation { get; set; }
        public string? SenderAddress { get; set; }
        public string? SenderSuburb { get; set; }
        public string? SenderState { get; set; }
        public string? SenderPostCode { get; set; }
        public string? SenderPzone { get; set; }
        public string? SenderAzone { get; set; }
        public string? SenderCzone { get; set; }
        public string? SenderDzone { get; set; }
        public string? SenderNote { get; set; }
        public string? SenderPhone { get; set; }
        public string? SenderGroup { get; set; }
        public Guid? ReceiverId { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverLocation { get; set; }
        public string? ReceiverAddress { get; set; }
        public string? ReceiverSuburb { get; set; }
        public string? ReceiverState { get; set; }
        public string? ReceiverPostCode { get; set; }
        public string? ReceiverPzone { get; set; }
        public string? ReceiverAzone { get; set; }
        public string? ReceiverCzone { get; set; }
        public string? ReceiverDzone { get; set; }
        public string? ReceiverNote { get; set; }
        public string? ReceiverPhone { get; set; }
        public string? ReceiverGroup { get; set; }
        public string? Products { get; set; }
        public string? ProductName { get; set; }
        public string? ProductDescription { get; set; }
        public string JobLegCustomActivities { get; set; } = null!;
        public string? JobLegBottleTrack { get; set; }
        public int? JobLegCount { get; set; }
        public int? FinishedJobLegCount { get; set; }
        public string? FirstLegManifestNumber { get; set; }
        public string? InvoiceStatus { get; set; }
        public string? InvoiceStatusId { get; set; }
        public string? InvoiceStatusColor { get; set; }
        public string? InvoiceNo { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public bool? HasJobPod { get; set; }
        public string? ActivePods { get; set; }
        public bool? HasHandwrittenPod { get; set; }
        public bool? AppPod { get; set; }
        public bool? IsPodrequired { get; set; }
        public bool? IsPodrequiredBeforeInvoicing { get; set; }
        public bool? IsCustomerPodrequired { get; set; }
        public string? SpecialInstructions { get; set; }
        public string? TrackingCode { get; set; }
        public string? JobLegIds { get; set; }
        public string? ShippingUnits { get; set; }
        public int? CreatedKind { get; set; }
        public string? AllJobPods { get; set; }
        public string? PricingType { get; set; }
        public string? JobNotes { get; set; }
        public string? PricingNotes { get; set; }
        public int? PodphotoCount { get; set; }
    }
}
