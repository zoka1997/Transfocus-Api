using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Job
    {
        public Job()
        {
            Attachments = new HashSet<Attachment>();
            CreditNoteReconciliations = new HashSet<CreditNoteReconciliation>();
            ExternalJobStatusImports = new HashSet<ExternalJobStatusImport>();
            HandwrittenPods = new HashSet<HandwrittenPod>();
            JobDocuments = new HashSet<JobDocument>();
            JobHistories = new HashSet<JobHistory>();
            JobLegs = new HashSet<JobLeg>();
            JobPrices = new HashSet<JobPrice>();
            JobPricings = new HashSet<JobPricing>();
            JobProducts = new HashSet<JobProduct>();
            JobTripStatusHistories = new HashSet<JobTripStatusHistory>();
            Notes = new HashSet<Note>();
            PanelInvoiceDeletedJobs = new HashSet<PanelInvoiceDeletedJob>();
            PaymentReconciliations = new HashSet<PaymentReconciliation>();
            RecurrenceJobLists = new HashSet<RecurrenceJobList>();
            RecurrenceJobScheduleRunHistoryNewJobs = new HashSet<RecurrenceJobScheduleRunHistory>();
            RecurrenceJobScheduleRunHistorySourceJobs = new HashSet<RecurrenceJobScheduleRunHistory>();
            References = new HashSet<Reference>();
            RoadTolls = new HashSet<RoadToll>();
        }

        public Guid Id { get; set; }
        public string JobNumber { get; set; } = null!;
        public int SystemJobNumber { get; set; }
        public string? JobReference { get; set; }
        public string JobStatusId { get; set; } = null!;
        public string JobImportTypeId { get; set; } = null!;
        public Guid CustomerId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? UserId { get; set; }
        public string? JobKindId { get; set; }
        public Guid? SenderId { get; set; }
        public Guid? RecipientId { get; set; }
        public string? SenderPhone { get; set; }
        public string? RecipientPhone { get; set; }
        public string? SenderNote { get; set; }
        public string? RecipientNote { get; set; }
        public string? SpecialInstructions { get; set; }
        public bool? Active { get; set; }
        public Guid? CompanyId { get; set; }
        public Guid? PodappUserId { get; set; }
        public bool? SenderPays { get; set; }
        public bool? RecipientPays { get; set; }
        public bool? ExportedToFoxpro { get; set; }
        public Guid? JobServiceCodeId { get; set; }
        public string? FoxProJobNumber { get; set; }
        public string? TrackingCode { get; set; }
        public int? JobSourceId { get; set; }
        public bool IsCrossDock { get; set; }
        public Guid? JobCancelResponseId { get; set; }
        public Guid? ProposedTimeSlotId { get; set; }
        public bool HasDangerousGoods { get; set; }
        public DateTime? CustomerRequiredDate { get; set; }
        public DateTime? ModifiedTimestamp { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? CreatedTimestamp { get; set; }
        public int? InvoiceNumber { get; set; }
        public Guid? InvoiceId { get; set; }
        public bool? FtpimportedPod { get; set; }
        public decimal? Hours { get; set; }
        public decimal PricingNet { get; set; }
        public decimal PricingGst { get; set; }
        public decimal PricingTotal { get; set; }
        public string? PricingStatusId { get; set; }
        public Guid? PanelInvoiceId { get; set; }
        public bool BackToDepot { get; set; }
        public decimal Quantity { get; set; }
        public decimal Pallets { get; set; }
        public decimal Weight { get; set; }
        public decimal Space { get; set; }
        public decimal Cubic { get; set; }
        public decimal Kms { get; set; }
        public decimal HoursTotal { get; set; }
        public decimal Waiting { get; set; }
        public DateTime? BookDate { get; set; }
        public DateTime? ReadyFromDate { get; set; }
        public string? AutoPricingLog { get; set; }
        public bool? AutoPriceComplete { get; set; }
        public decimal CubicWeight { get; set; }
        public decimal? Otweight { get; set; }
        public decimal? Delweight { get; set; }
        public decimal? ContractWeight { get; set; }
        public decimal? ContractBal { get; set; }
        public string? BookingType { get; set; }
        public string? WeightType { get; set; }
        public Guid? ProductOwner { get; set; }
        public Guid? FleetConfigurationId { get; set; }
        public DateTime? ContractScheduleStart { get; set; }
        public DateTime? ContractScheduleFinish { get; set; }
        public string? DailyWeight { get; set; }
        public bool? FreightBroughtToDepot { get; set; }
        public bool? FreightWillBePickedFromDepot { get; set; }
        public decimal? TripWeight { get; set; }
        public DateTime? CustomerRequiredEndTime { get; set; }
        public int Drops { get; set; }
        public decimal? ReadyFromCustomOffset { get; set; }
        public decimal? CustomOffset { get; set; }
        public bool InvoicingOnly { get; set; }
        public Guid? DepotId { get; set; }
        public Guid? BookingContactId { get; set; }
        public string? Refrence1 { get; set; }
        public string? Refrence2 { get; set; }
        public string? Refrence3 { get; set; }
        public string? Refrence4 { get; set; }
        public string? Refrence5 { get; set; }
        public string? Refrence6 { get; set; }
        public string? Refrence7 { get; set; }
        public string? Refrence8 { get; set; }
        public string? Refrence9 { get; set; }
        public string? Refrence10 { get; set; }
        public string? TripStatusId { get; set; }
        public decimal ChargeWeight { get; set; }
        public Guid? SenderContact { get; set; }
        public Guid? ReceiverContact { get; set; }
        public decimal CostingTotal { get; set; }
        public decimal ExpenseTotal { get; set; }
        public int? ChepPallets { get; set; }
        public int? LocscamPallets { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? Group2Id { get; set; }

        public virtual Contact? BookingContact { get; set; }
        public virtual Company? Company { get; set; }
        public virtual Customer Customer { get; set; } = null!;
        public virtual Location? Depot { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual Invoice? Invoice { get; set; }
        public virtual JobCancelResponse? JobCancelResponse { get; set; }
        public virtual JobImportType JobImportType { get; set; } = null!;
        public virtual JobKind? JobKind { get; set; }
        public virtual ServiceCode? JobServiceCode { get; set; }
        public virtual JobSource? JobSource { get; set; }
        public virtual JobStatus JobStatus { get; set; } = null!;
        public virtual WebPanelUser? ModifiedByNavigation { get; set; }
        public virtual PanelInvoice? PanelInvoice { get; set; }
        public virtual User? PodappUser { get; set; }
        public virtual PricingStatus? PricingStatus { get; set; }
        public virtual Customer? ProductOwnerNavigation { get; set; }
        public virtual TimeSlot? ProposedTimeSlot { get; set; }
        public virtual Contact? ReceiverContactNavigation { get; set; }
        public virtual Location? Recipient { get; set; }
        public virtual Location? Sender { get; set; }
        public virtual Contact? SenderContactNavigation { get; set; }
        public virtual JobTripStatus? TripStatus { get; set; }
        public virtual WebPanelUser? User { get; set; }
        public virtual ICollection<Attachment> Attachments { get; set; }
        public virtual ICollection<CreditNoteReconciliation> CreditNoteReconciliations { get; set; }
        public virtual ICollection<ExternalJobStatusImport> ExternalJobStatusImports { get; set; }
        public virtual ICollection<HandwrittenPod> HandwrittenPods { get; set; }
        public virtual ICollection<JobDocument> JobDocuments { get; set; }
        public virtual ICollection<JobHistory> JobHistories { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<JobPrice> JobPrices { get; set; }
        public virtual ICollection<JobPricing> JobPricings { get; set; }
        public virtual ICollection<JobProduct> JobProducts { get; set; }
        public virtual ICollection<JobTripStatusHistory> JobTripStatusHistories { get; set; }
        public virtual ICollection<Note> Notes { get; set; }
        public virtual ICollection<PanelInvoiceDeletedJob> PanelInvoiceDeletedJobs { get; set; }
        public virtual ICollection<PaymentReconciliation> PaymentReconciliations { get; set; }
        public virtual ICollection<RecurrenceJobList> RecurrenceJobLists { get; set; }
        public virtual ICollection<RecurrenceJobScheduleRunHistory> RecurrenceJobScheduleRunHistoryNewJobs { get; set; }
        public virtual ICollection<RecurrenceJobScheduleRunHistory> RecurrenceJobScheduleRunHistorySourceJobs { get; set; }
        public virtual ICollection<Reference> References { get; set; }
        public virtual ICollection<RoadToll> RoadTolls { get; set; }
    }
}
