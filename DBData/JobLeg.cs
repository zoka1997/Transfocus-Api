using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLeg
    {
        public JobLeg()
        {
            BottleTracks = new HashSet<BottleTrack>();
            Exports = new HashSet<Export>();
            HandwrittenPods = new HashSet<HandwrittenPod>();
            JobLegActivities = new HashSet<JobLegActivity>();
            JobLegCostingStatusHistories = new HashSet<JobLegCostingStatusHistory>();
            JobLegCostings = new HashSet<JobLegCosting>();
            JobLegCustomActivities = new HashSet<JobLegCustomActivity>();
            JobLegHistories = new HashSet<JobLegHistory>();
            JobLegPallets = new HashSet<JobLegPallet>();
            JobLegProducts = new HashSet<JobLegProduct>();
            JobLegStatusHistories = new HashSet<JobLegStatusHistory>();
            MassManagementJobLegs = new HashSet<MassManagementJobLeg>();
            MobileLogs = new HashSet<MobileLog>();
            OdometerReadingJobLegs = new HashSet<OdometerReadingJobLeg>();
            PalletTransactions = new HashSet<PalletTransaction>();
            Podphotos = new HashSet<Podphoto>();
            Podsignatures = new HashSet<Podsignature>();
            RevokedManifestJobLegs = new HashSet<RevokedManifestJobLeg>();
            SenderSignatures = new HashSet<SenderSignature>();
            SubcontractorPayments = new HashSet<SubcontractorPayment>();
        }

        public Guid Id { get; set; }
        public string JobNumber { get; set; } = null!;
        public string JobReference { get; set; } = null!;
        public string ConsignmentNumber { get; set; } = null!;
        public string ConsignmentReference { get; set; } = null!;
        public string? Instructions { get; set; }
        public string? SignedBy { get; set; }
        public bool Signed { get; set; }
        public int RouteOrder { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public string TripStatusId { get; set; } = null!;
        public string? PodstatusId { get; set; }
        public string? PodexceptionId { get; set; }
        public string JobLegTypeId { get; set; } = null!;
        public string JobTypeId { get; set; } = null!;
        public string JobKindId { get; set; } = null!;
        public bool UseScanLoad { get; set; }
        public bool UseScanOff { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecepientId { get; set; }
        public string? SenderNote { get; set; }
        public string? SenderPhone { get; set; }
        public string? RecepientNote { get; set; }
        public string? RecepientPhone { get; set; }
        public string? WorkflowId { get; set; }
        public string? WorkflowSubId { get; set; }
        public bool TakenShort { get; set; }
        public Guid CustomerId { get; set; }
        public DateTime? Eta { get; set; }
        public DateTime? ArrivedSenderTimestamp { get; set; }
        public DateTime? ArrivedReceiverTimestamp { get; set; }
        public DateTime? DepartedSenderTimestamp { get; set; }
        public DateTime? DepartedReceiverTimestamp { get; set; }
        public string? PodexceptionNote { get; set; }
        public bool Acknowledged { get; set; }
        public DateTime? TimestampAcknowledged { get; set; }
        public string? ServiceCode { get; set; }
        public string? ReleaseNumber { get; set; }
        public decimal? Weight { get; set; }
        public string? CustomerReference { get; set; }
        public string? Doors { get; set; }
        public DateTime? DueTimestamp { get; set; }
        public Guid? Trailer1Id { get; set; }
        public Guid? Trailer2Id { get; set; }
        public bool? Active { get; set; }
        public string? TrackingCode { get; set; }
        public Guid? JobId { get; set; }
        public bool Recalled { get; set; }
        public int OrderNumber { get; set; }
        public int? SenderWaitingTime { get; set; }
        public int? ReceiverWaitingTime { get; set; }
        public string? SenderSignedBy { get; set; }
        public bool? SenderSigned { get; set; }
        public Guid? ManifestId { get; set; }
        public Guid? ServiceCodeId { get; set; }
        public int LegNumber { get; set; }
        public int? ManifestJobLegOrderNumber { get; set; }
        public int? CourierPickupOrderNumber { get; set; }
        public int? CourierDeliveryOrderNumber { get; set; }
        public Guid? TimeSlotId { get; set; }
        public string? FoxProJobLegNumber { get; set; }
        public string? MasterNumber { get; set; }
        public string? Product { get; set; }
        public int DeliveryAttempt { get; set; }
        public int? ManifestSequenceNumber { get; set; }
        public Guid? FleetConfigurationId { get; set; }
        public bool IsUploadedToDropbox { get; set; }
        public Guid? DepotId { get; set; }
        public string? LegStatusId { get; set; }
        public bool? IsSplitLeg { get; set; }
        public string? CostingStatusId { get; set; }
        public Guid? PanelInvoiceId { get; set; }
        public decimal LegCost { get; set; }
        public decimal LegExpense { get; set; }
        public decimal Price { get; set; }
        public decimal? LegTotalQuantity { get; set; }
        public decimal LegNettCost { get; set; }
        public string? AutoCostingLog { get; set; }
        public bool? AutoCostComplete { get; set; }
        public Guid? ParentLocationId { get; set; }
        public Guid? ParentLegId { get; set; }
        public string? SenderAppNote { get; set; }
        public string? ReceiverAppNote { get; set; }
        public string? Note { get; set; }
        public string? SmartFreightConsignmentId { get; set; }
        public string? HiTransConsignmentId { get; set; }
        public decimal? LegTotalKilometers { get; set; }
        public decimal? LegTotalHours { get; set; }
        public bool EdiStatus { get; set; }
        public bool EdiStatusArrivedSenderTimestamp { get; set; }
        public bool EdiStatusDepartedSenderTimestamp { get; set; }
        public bool EdiStatusArrivedReceiverTimestamp { get; set; }
        public bool EdiStatusDepartedReceiverTimestamp { get; set; }

        public virtual CostingStatus? CostingStatus { get; set; }
        public virtual Customer Customer { get; set; } = null!;
        public virtual Location? Depot { get; set; }
        public virtual User? Driver { get; set; }
        public virtual FleetConfiguration? FleetConfiguration { get; set; }
        public virtual Job? Job { get; set; }
        public virtual JobKind JobKind { get; set; } = null!;
        public virtual JobLegType JobLegType { get; set; } = null!;
        public virtual JobType JobType { get; set; } = null!;
        public virtual LegStatus? LegStatus { get; set; }
        public virtual Manifest? Manifest { get; set; }
        public virtual PanelInvoice? PanelInvoice { get; set; }
        public virtual Podexception? Podexception { get; set; }
        public virtual Podstatus? Podstatus { get; set; }
        public virtual Location Recepient { get; set; } = null!;
        public virtual Location Sender { get; set; } = null!;
        public virtual ServiceCode? ServiceCodeNavigation { get; set; }
        public virtual TimeSlot? TimeSlot { get; set; }
        public virtual Vehicle? Trailer1 { get; set; }
        public virtual Vehicle? Trailer2 { get; set; }
        public virtual TripStatus TripStatus { get; set; } = null!;
        public virtual Vehicle? Vehicle { get; set; }
        public virtual WorkflowKind? Workflow { get; set; }
        public virtual WorkflowSubKind? WorkflowSub { get; set; }
        public virtual ICollection<BottleTrack> BottleTracks { get; set; }
        public virtual ICollection<Export> Exports { get; set; }
        public virtual ICollection<HandwrittenPod> HandwrittenPods { get; set; }
        public virtual ICollection<JobLegActivity> JobLegActivities { get; set; }
        public virtual ICollection<JobLegCostingStatusHistory> JobLegCostingStatusHistories { get; set; }
        public virtual ICollection<JobLegCosting> JobLegCostings { get; set; }
        public virtual ICollection<JobLegCustomActivity> JobLegCustomActivities { get; set; }
        public virtual ICollection<JobLegHistory> JobLegHistories { get; set; }
        public virtual ICollection<JobLegPallet> JobLegPallets { get; set; }
        public virtual ICollection<JobLegProduct> JobLegProducts { get; set; }
        public virtual ICollection<JobLegStatusHistory> JobLegStatusHistories { get; set; }
        public virtual ICollection<MassManagementJobLeg> MassManagementJobLegs { get; set; }
        public virtual ICollection<MobileLog> MobileLogs { get; set; }
        public virtual ICollection<OdometerReadingJobLeg> OdometerReadingJobLegs { get; set; }
        public virtual ICollection<PalletTransaction> PalletTransactions { get; set; }
        public virtual ICollection<Podphoto> Podphotos { get; set; }
        public virtual ICollection<Podsignature> Podsignatures { get; set; }
        public virtual ICollection<RevokedManifestJobLeg> RevokedManifestJobLegs { get; set; }
        public virtual ICollection<SenderSignature> SenderSignatures { get; set; }
        public virtual ICollection<SubcontractorPayment> SubcontractorPayments { get; set; }
    }
}
