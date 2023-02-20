using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TransfocusBack.DBData
{
    public partial class transfocusqa20229261212Context : DbContext
    {
        public transfocusqa20229261212Context()
        {
        }

        public transfocusqa20229261212Context(DbContextOptions<transfocusqa20229261212Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountingSystem> AccountingSystems { get; set; } = null!;
        public virtual DbSet<AccountingSystemInstance> AccountingSystemInstances { get; set; } = null!;
        public virtual DbSet<AccountingSystemInterfaceType> AccountingSystemInterfaceTypes { get; set; } = null!;
        public virtual DbSet<Activity> Activities { get; set; } = null!;
        public virtual DbSet<AfterBookingRoute> AfterBookingRoutes { get; set; } = null!;
        public virtual DbSet<AggregatedCounter> AggregatedCounters { get; set; } = null!;
        public virtual DbSet<Apikey> Apikeys { get; set; } = null!;
        public virtual DbSet<AspnetApplication> AspnetApplications { get; set; } = null!;
        public virtual DbSet<AspnetMembership> AspnetMemberships { get; set; } = null!;
        public virtual DbSet<AspnetPath> AspnetPaths { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationAllUser> AspnetPersonalizationAllUsers { get; set; } = null!;
        public virtual DbSet<AspnetPersonalizationPerUser> AspnetPersonalizationPerUsers { get; set; } = null!;
        public virtual DbSet<AspnetProfile> AspnetProfiles { get; set; } = null!;
        public virtual DbSet<AspnetRole> AspnetRoles { get; set; } = null!;
        public virtual DbSet<AspnetSchemaVersion> AspnetSchemaVersions { get; set; } = null!;
        public virtual DbSet<AspnetUser> AspnetUsers { get; set; } = null!;
        public virtual DbSet<AspnetWebEventEvent> AspnetWebEventEvents { get; set; } = null!;
        public virtual DbSet<Attachment> Attachments { get; set; } = null!;
        public virtual DbSet<AuditLog> AuditLogs { get; set; } = null!;
        public virtual DbSet<AuthToken> AuthTokens { get; set; } = null!;
        public virtual DbSet<AutomaticEdilog> AutomaticEdilogs { get; set; } = null!;
        public virtual DbSet<AvailableServiceCode> AvailableServiceCodes { get; set; } = null!;
        public virtual DbSet<BookingPrintOption> BookingPrintOptions { get; set; } = null!;
        public virtual DbSet<BookingTemplate> BookingTemplates { get; set; } = null!;
        public virtual DbSet<BottleTrack> BottleTracks { get; set; } = null!;
        public virtual DbSet<BottleTrackShippingUnit> BottleTrackShippingUnits { get; set; } = null!;
        public virtual DbSet<CheckList> CheckLists { get; set; } = null!;
        public virtual DbSet<CheckListsHistory> CheckListsHistories { get; set; } = null!;
        public virtual DbSet<Company> Companies { get; set; } = null!;
        public virtual DbSet<CompanyCompliance> CompanyCompliances { get; set; } = null!;
        public virtual DbSet<CompanyHistory> CompanyHistories { get; set; } = null!;
        public virtual DbSet<CompanyToll> CompanyTolls { get; set; } = null!;
        public virtual DbSet<Compliance> Compliances { get; set; } = null!;
        public virtual DbSet<ComplianceType> ComplianceTypes { get; set; } = null!;
        public virtual DbSet<ConsignmentReportProductView> ConsignmentReportProductViews { get; set; } = null!;
        public virtual DbSet<ConsignmentReportView> ConsignmentReportViews { get; set; } = null!;
        public virtual DbSet<ConsolidatedConsignmentNote> ConsolidatedConsignmentNotes { get; set; } = null!;
        public virtual DbSet<Contact> Contacts { get; set; } = null!;
        public virtual DbSet<ContactConfig> ContactConfigs { get; set; } = null!;
        public virtual DbSet<ContactObject> ContactObjects { get; set; } = null!;
        public virtual DbSet<ContactSetting> ContactSettings { get; set; } = null!;
        public virtual DbSet<ContactType> ContactTypes { get; set; } = null!;
        public virtual DbSet<ContactTypeDetail> ContactTypeDetails { get; set; } = null!;
        public virtual DbSet<ConversationParticipant> ConversationParticipants { get; set; } = null!;
        public virtual DbSet<CostGroup> CostGroups { get; set; } = null!;
        public virtual DbSet<CostJobCard> CostJobCards { get; set; } = null!;
        public virtual DbSet<CostProductCard> CostProductCards { get; set; } = null!;
        public virtual DbSet<CostingOptionalItem> CostingOptionalItems { get; set; } = null!;
        public virtual DbSet<CostingSchedule> CostingSchedules { get; set; } = null!;
        public virtual DbSet<CostingScheduleStatus> CostingScheduleStatuses { get; set; } = null!;
        public virtual DbSet<CostingServiceLane> CostingServiceLanes { get; set; } = null!;
        public virtual DbSet<CostingStatus> CostingStatuses { get; set; } = null!;
        public virtual DbSet<Counter> Counters { get; set; } = null!;
        public virtual DbSet<Country> Countries { get; set; } = null!;
        public virtual DbSet<CreditNoteReconciliation> CreditNoteReconciliations { get; set; } = null!;
        public virtual DbSet<CreditNoteSalesLedger> CreditNoteSalesLedgers { get; set; } = null!;
        public virtual DbSet<CubicWeightConversionRate> CubicWeightConversionRates { get; set; } = null!;
        public virtual DbSet<CustomActivity> CustomActivities { get; set; } = null!;
        public virtual DbSet<CustomActivityPhoto> CustomActivityPhotos { get; set; } = null!;
        public virtual DbSet<CustomActivityProduct> CustomActivityProducts { get; set; } = null!;
        public virtual DbSet<CustomPage> CustomPages { get; set; } = null!;
        public virtual DbSet<CustomReference> CustomReferences { get; set; } = null!;
        public virtual DbSet<Customer> Customers { get; set; } = null!;
        public virtual DbSet<CustomerContact> CustomerContacts { get; set; } = null!;
        public virtual DbSet<CustomerLocation> CustomerLocations { get; set; } = null!;
        public virtual DbSet<CustomerNote> CustomerNotes { get; set; } = null!;
        public virtual DbSet<CustomerPricingNote> CustomerPricingNotes { get; set; } = null!;
        public virtual DbSet<CustomerProduct> CustomerProducts { get; set; } = null!;
        public virtual DbSet<CustomersEnquiryView> CustomersEnquiryViews { get; set; } = null!;
        public virtual DbSet<DebtorNote> DebtorNotes { get; set; } = null!;
        public virtual DbSet<DefaultAccount> DefaultAccounts { get; set; } = null!;
        public virtual DbSet<DeviceCrashLog> DeviceCrashLogs { get; set; } = null!;
        public virtual DbSet<DriverSignature> DriverSignatures { get; set; } = null!;
        public virtual DbSet<DriverWorkingTime> DriverWorkingTimes { get; set; } = null!;
        public virtual DbSet<Edilog> Edilogs { get; set; } = null!;
        public virtual DbSet<EdilogDetail> EdilogDetails { get; set; } = null!;
        public virtual DbSet<Edipath> Edipaths { get; set; } = null!;
        public virtual DbSet<EmailAttachment> EmailAttachments { get; set; } = null!;
        public virtual DbSet<EmailAttachmentsCleanUpHistory> EmailAttachmentsCleanUpHistories { get; set; } = null!;
        public virtual DbSet<EmailHistory> EmailHistories { get; set; } = null!;
        public virtual DbSet<EmailQueue> EmailQueues { get; set; } = null!;
        public virtual DbSet<EmailSmstemplate> EmailSmstemplates { get; set; } = null!;
        public virtual DbSet<EnquiryView> EnquiryViews { get; set; } = null!;
        public virtual DbSet<Export> Exports { get; set; } = null!;
        public virtual DbSet<ExportType> ExportTypes { get; set; } = null!;
        public virtual DbSet<ExportedPayment> ExportedPayments { get; set; } = null!;
        public virtual DbSet<ExternalJobStatus> ExternalJobStatuses { get; set; } = null!;
        public virtual DbSet<ExternalJobStatusImport> ExternalJobStatusImports { get; set; } = null!;
        public virtual DbSet<ExternalJobStatusMapping> ExternalJobStatusMappings { get; set; } = null!;
        public virtual DbSet<FinancialStatementType> FinancialStatementTypes { get; set; } = null!;
        public virtual DbSet<FleetAsset> FleetAssets { get; set; } = null!;
        public virtual DbSet<FleetAssetAdditionalDetail> FleetAssetAdditionalDetails { get; set; } = null!;
        public virtual DbSet<FleetAssetAttachment> FleetAssetAttachments { get; set; } = null!;
        public virtual DbSet<FleetAssetAxleWeight> FleetAssetAxleWeights { get; set; } = null!;
        public virtual DbSet<FleetAssetCapacity> FleetAssetCapacities { get; set; } = null!;
        public virtual DbSet<FleetAssetFuelType> FleetAssetFuelTypes { get; set; } = null!;
        public virtual DbSet<FleetAssetMake> FleetAssetMakes { get; set; } = null!;
        public virtual DbSet<FleetAssetModel> FleetAssetModels { get; set; } = null!;
        public virtual DbSet<FleetAssetSubtype> FleetAssetSubtypes { get; set; } = null!;
        public virtual DbSet<FleetAssetType> FleetAssetTypes { get; set; } = null!;
        public virtual DbSet<FleetConfiguration> FleetConfigurations { get; set; } = null!;
        public virtual DbSet<FleetRunningCost> FleetRunningCosts { get; set; } = null!;
        public virtual DbSet<FleetRunningCostType> FleetRunningCostTypes { get; set; } = null!;
        public virtual DbSet<FoxProSyncDate> FoxProSyncDates { get; set; } = null!;
        public virtual DbSet<GeneralToll> GeneralTolls { get; set; } = null!;
        public virtual DbSet<GenericGroup> GenericGroups { get; set; } = null!;
        public virtual DbSet<GlobalAlert> GlobalAlerts { get; set; } = null!;
        public virtual DbSet<Gpslog> Gpslogs { get; set; } = null!;
        public virtual DbSet<GridStateColumn> GridStateColumns { get; set; } = null!;
        public virtual DbSet<GridStateDefault> GridStateDefaults { get; set; } = null!;
        public virtual DbSet<GridStateProfile> GridStateProfiles { get; set; } = null!;
        public virtual DbSet<GridStateProfilePermission> GridStateProfilePermissions { get; set; } = null!;
        public virtual DbSet<Gstcode> Gstcodes { get; set; } = null!;
        public virtual DbSet<HandwrittenPod> HandwrittenPods { get; set; } = null!;
        public virtual DbSet<Hash> Hashes { get; set; } = null!;
        public virtual DbSet<ImportHistory> ImportHistories { get; set; } = null!;
        public virtual DbSet<ImportType> ImportTypes { get; set; } = null!;
        public virtual DbSet<ImportedContactsForUpdate> ImportedContactsForUpdates { get; set; } = null!;
        public virtual DbSet<ImportedCustomersForUpdate> ImportedCustomersForUpdates { get; set; } = null!;
        public virtual DbSet<ImportedJob> ImportedJobs { get; set; } = null!;
        public virtual DbSet<ImportedJobPricing> ImportedJobPricings { get; set; } = null!;
        public virtual DbSet<ImportedJobProduct> ImportedJobProducts { get; set; } = null!;
        public virtual DbSet<InterfaceType> InterfaceTypes { get; set; } = null!;
        public virtual DbSet<InterfaceVersion> InterfaceVersions { get; set; } = null!;
        public virtual DbSet<InternalTrackStatus> InternalTrackStatuses { get; set; } = null!;
        public virtual DbSet<Invoice> Invoices { get; set; } = null!;
        public virtual DbSet<InvoiceBatch> InvoiceBatches { get; set; } = null!;
        public virtual DbSet<InvoiceDeliveryMethod> InvoiceDeliveryMethods { get; set; } = null!;
        public virtual DbSet<InvoiceNumberTemp> InvoiceNumberTemps { get; set; } = null!;
        public virtual DbSet<InvoiceSalesJournalExport> InvoiceSalesJournalExports { get; set; } = null!;
        public virtual DbSet<InvoiceSalesJournalExportedInvoice> InvoiceSalesJournalExportedInvoices { get; set; } = null!;
        public virtual DbSet<InvoiceStatus> InvoiceStatuses { get; set; } = null!;
        public virtual DbSet<InvoicingFrequency> InvoicingFrequencies { get; set; } = null!;
        public virtual DbSet<InvoicingGrouping> InvoicingGroupings { get; set; } = null!;
        public virtual DbSet<InvoicingUitext> InvoicingUitexts { get; set; } = null!;
        public virtual DbSet<Job> Jobs { get; set; } = null!;
        public virtual DbSet<Job1> Jobs1 { get; set; } = null!;
        public virtual DbSet<JobCancelReason> JobCancelReasons { get; set; } = null!;
        public virtual DbSet<JobCancelResponse> JobCancelResponses { get; set; } = null!;
        public virtual DbSet<JobCode> JobCodes { get; set; } = null!;
        public virtual DbSet<JobDocument> JobDocuments { get; set; } = null!;
        public virtual DbSet<JobDocumentType> JobDocumentTypes { get; set; } = null!;
        public virtual DbSet<JobHistory> JobHistories { get; set; } = null!;
        public virtual DbSet<JobImportMatch> JobImportMatches { get; set; } = null!;
        public virtual DbSet<JobImportMethod> JobImportMethods { get; set; } = null!;
        public virtual DbSet<JobImportMode> JobImportModes { get; set; } = null!;
        public virtual DbSet<JobImportRejectMethod> JobImportRejectMethods { get; set; } = null!;
        public virtual DbSet<JobImportType> JobImportTypes { get; set; } = null!;
        public virtual DbSet<JobKind> JobKinds { get; set; } = null!;
        public virtual DbSet<JobLeg> JobLegs { get; set; } = null!;
        public virtual DbSet<JobLegActivity> JobLegActivities { get; set; } = null!;
        public virtual DbSet<JobLegCosting> JobLegCostings { get; set; } = null!;
        public virtual DbSet<JobLegCostingStatusHistory> JobLegCostingStatusHistories { get; set; } = null!;
        public virtual DbSet<JobLegCustomActivity> JobLegCustomActivities { get; set; } = null!;
        public virtual DbSet<JobLegCustomActivityHistory> JobLegCustomActivityHistories { get; set; } = null!;
        public virtual DbSet<JobLegHistory> JobLegHistories { get; set; } = null!;
        public virtual DbSet<JobLegPallet> JobLegPallets { get; set; } = null!;
        public virtual DbSet<JobLegProduct> JobLegProducts { get; set; } = null!;
        public virtual DbSet<JobLegStatusHistory> JobLegStatusHistories { get; set; } = null!;
        public virtual DbSet<JobLegType> JobLegTypes { get; set; } = null!;
        public virtual DbSet<JobParameter> JobParameters { get; set; } = null!;
        public virtual DbSet<JobPrice> JobPrices { get; set; } = null!;
        public virtual DbSet<JobPricing> JobPricings { get; set; } = null!;
        public virtual DbSet<JobPricingHistory> JobPricingHistories { get; set; } = null!;
        public virtual DbSet<JobProduct> JobProducts { get; set; } = null!;
        public virtual DbSet<JobProductHistory> JobProductHistories { get; set; } = null!;
        public virtual DbSet<JobQueue> JobQueues { get; set; } = null!;
        public virtual DbSet<JobSenderRecipientDefault> JobSenderRecipientDefaults { get; set; } = null!;
        public virtual DbSet<JobSource> JobSources { get; set; } = null!;
        public virtual DbSet<JobStatus> JobStatuses { get; set; } = null!;
        public virtual DbSet<JobTripStatus> JobTripStatuses { get; set; } = null!;
        public virtual DbSet<JobTripStatusHistory> JobTripStatusHistories { get; set; } = null!;
        public virtual DbSet<JobType> JobTypes { get; set; } = null!;
        public virtual DbSet<LegCreationMethod> LegCreationMethods { get; set; } = null!;
        public virtual DbSet<LegStatus> LegStatuses { get; set; } = null!;
        public virtual DbSet<List> Lists { get; set; } = null!;
        public virtual DbSet<Location> Locations { get; set; } = null!;
        public virtual DbSet<LocationPolygon> LocationPolygons { get; set; } = null!;
        public virtual DbSet<LocationType> LocationTypes { get; set; } = null!;
        public virtual DbSet<LocationUseType> LocationUseTypes { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<Manifest> Manifests { get; set; } = null!;
        public virtual DbSet<ManifestHistory> ManifestHistories { get; set; } = null!;
        public virtual DbSet<ManifestName> ManifestNames { get; set; } = null!;
        public virtual DbSet<ManifestStatus> ManifestStatuses { get; set; } = null!;
        public virtual DbSet<ManifestType> ManifestTypes { get; set; } = null!;
        public virtual DbSet<MapDefaultCentre> MapDefaultCentres { get; set; } = null!;
        public virtual DbSet<MassManagement> MassManagements { get; set; } = null!;
        public virtual DbSet<MassManagementJobLeg> MassManagementJobLegs { get; set; } = null!;
        public virtual DbSet<Message> Messages { get; set; } = null!;
        public virtual DbSet<Messaging> Messagings { get; set; } = null!;
        public virtual DbSet<Mileage> Mileages { get; set; } = null!;
        public virtual DbSet<MobileDevice> MobileDevices { get; set; } = null!;
        public virtual DbSet<MobileLog> MobileLogs { get; set; } = null!;
        public virtual DbSet<Note> Notes { get; set; } = null!;
        public virtual DbSet<Notification> Notifications { get; set; } = null!;
        public virtual DbSet<OdometerReading> OdometerReadings { get; set; } = null!;
        public virtual DbSet<OdometerReadingJobLeg> OdometerReadingJobLegs { get; set; } = null!;
        public virtual DbSet<OpeningHour> OpeningHours { get; set; } = null!;
        public virtual DbSet<PalletAccount> PalletAccounts { get; set; } = null!;
        public virtual DbSet<PalletAddressAccount> PalletAddressAccounts { get; set; } = null!;
        public virtual DbSet<PalletMovementType> PalletMovementTypes { get; set; } = null!;
        public virtual DbSet<PalletTransaction> PalletTransactions { get; set; } = null!;
        public virtual DbSet<PalletType> PalletTypes { get; set; } = null!;
        public virtual DbSet<PanelInvoice> PanelInvoices { get; set; } = null!;
        public virtual DbSet<PanelInvoiceDeletedJob> PanelInvoiceDeletedJobs { get; set; } = null!;
        public virtual DbSet<PanelInvoiceHistory> PanelInvoiceHistories { get; set; } = null!;
        public virtual DbSet<PanelInvoiceStatus> PanelInvoiceStatuses { get; set; } = null!;
        public virtual DbSet<PanelInvoiceStatusName> PanelInvoiceStatusNames { get; set; } = null!;
        public virtual DbSet<PanelInvoiceType> PanelInvoiceTypes { get; set; } = null!;
        public virtual DbSet<PanelInvoiceView> PanelInvoiceViews { get; set; } = null!;
        public virtual DbSet<Payment> Payments { get; set; } = null!;
        public virtual DbSet<PaymentItem> PaymentItems { get; set; } = null!;
        public virtual DbSet<PaymentReconciliation> PaymentReconciliations { get; set; } = null!;
        public virtual DbSet<PaymentSalesLedger> PaymentSalesLedgers { get; set; } = null!;
        public virtual DbSet<PaymentStatus> PaymentStatuses { get; set; } = null!;
        public virtual DbSet<PaymentStatusSalesLedger> PaymentStatusSalesLedgers { get; set; } = null!;
        public virtual DbSet<PaymentTerm> PaymentTerms { get; set; } = null!;
        public virtual DbSet<PaymentType> PaymentTypes { get; set; } = null!;
        public virtual DbSet<PersonalCustomerLocation> PersonalCustomerLocations { get; set; } = null!;
        public virtual DbSet<PersonalLocationType> PersonalLocationTypes { get; set; } = null!;
        public virtual DbSet<Podexception> Podexceptions { get; set; } = null!;
        public virtual DbSet<Podphoto> Podphotos { get; set; } = null!;
        public virtual DbSet<Podsignature> Podsignatures { get; set; } = null!;
        public virtual DbSet<Podstatus> Podstatuses { get; set; } = null!;
        public virtual DbSet<PriceJobTotal> PriceJobTotals { get; set; } = null!;
        public virtual DbSet<PriceProductCard> PriceProductCards { get; set; } = null!;
        public virtual DbSet<Pricing> Pricings { get; set; } = null!;
        public virtual DbSet<PricingChargeUnit> PricingChargeUnits { get; set; } = null!;
        public virtual DbSet<PricingDependence> PricingDependences { get; set; } = null!;
        public virtual DbSet<PricingHistory> PricingHistories { get; set; } = null!;
        public virtual DbSet<PricingInvoice> PricingInvoices { get; set; } = null!;
        public virtual DbSet<PricingSchedule> PricingSchedules { get; set; } = null!;
        public virtual DbSet<PricingScheduleCustomer> PricingScheduleCustomers { get; set; } = null!;
        public virtual DbSet<PricingScheduleStatus> PricingScheduleStatuses { get; set; } = null!;
        public virtual DbSet<PricingScheduleType> PricingScheduleTypes { get; set; } = null!;
        public virtual DbSet<PricingStatus> PricingStatuses { get; set; } = null!;
        public virtual DbSet<Product> Products { get; set; } = null!;
        public virtual DbSet<ProductLocation> ProductLocations { get; set; } = null!;
        public virtual DbSet<ProductPriceEnquiryView> ProductPriceEnquiryViews { get; set; } = null!;
        public virtual DbSet<PublicHoliday> PublicHolidays { get; set; } = null!;
        public virtual DbSet<RangePricing> RangePricings { get; set; } = null!;
        public virtual DbSet<RapidCheckList> RapidCheckLists { get; set; } = null!;
        public virtual DbSet<RecurrenceJobList> RecurrenceJobLists { get; set; } = null!;
        public virtual DbSet<RecurrenceJobSchedule> RecurrenceJobSchedules { get; set; } = null!;
        public virtual DbSet<RecurrenceJobScheduleRun> RecurrenceJobScheduleRuns { get; set; } = null!;
        public virtual DbSet<RecurrenceJobScheduleRunHistory> RecurrenceJobScheduleRunHistories { get; set; } = null!;
        public virtual DbSet<Reference> References { get; set; } = null!;
        public virtual DbSet<ReferenceType> ReferenceTypes { get; set; } = null!;
        public virtual DbSet<Report> Reports { get; set; } = null!;
        public virtual DbSet<ReportCompanyList> ReportCompanyLists { get; set; } = null!;
        public virtual DbSet<ReportsApiauth> ReportsApiauths { get; set; } = null!;
        public virtual DbSet<RevokedManifestJobLeg> RevokedManifestJobLegs { get; set; } = null!;
        public virtual DbSet<RoadToll> RoadTolls { get; set; } = null!;
        public virtual DbSet<Schema> Schemas { get; set; } = null!;
        public virtual DbSet<SendInvoiceMethod> SendInvoiceMethods { get; set; } = null!;
        public virtual DbSet<SenderSignature> SenderSignatures { get; set; } = null!;
        public virtual DbSet<Server> Servers { get; set; } = null!;
        public virtual DbSet<ServiceCode> ServiceCodes { get; set; } = null!;
        public virtual DbSet<ServiceCodeProduct> ServiceCodeProducts { get; set; } = null!;
        public virtual DbSet<ServiceLane> ServiceLanes { get; set; } = null!;
        public virtual DbSet<ServiceLaneStatus> ServiceLaneStatuses { get; set; } = null!;
        public virtual DbSet<Set> Sets { get; set; } = null!;
        public virtual DbSet<Smsqueue> Smsqueues { get; set; } = null!;
        public virtual DbSet<Spabatch> Spabatches { get; set; } = null!;
        public virtual DbSet<SplitExpenseRule> SplitExpenseRules { get; set; } = null!;
        public virtual DbSet<SplitPriceRule> SplitPriceRules { get; set; } = null!;
        public virtual DbSet<State> States { get; set; } = null!;
        public virtual DbSet<State1> States1 { get; set; } = null!;
        public virtual DbSet<Subcontractor> Subcontractors { get; set; } = null!;
        public virtual DbSet<SubcontractorLocationZone> SubcontractorLocationZones { get; set; } = null!;
        public virtual DbSet<SubcontractorPayment> SubcontractorPayments { get; set; } = null!;
        public virtual DbSet<SubcontractorPaymentStatus> SubcontractorPaymentStatuses { get; set; } = null!;
        public virtual DbSet<SubcontractorStaff> SubcontractorStaffs { get; set; } = null!;
        public virtual DbSet<Suburb> Suburbs { get; set; } = null!;
        public virtual DbSet<SuburbDistanceConfig> SuburbDistanceConfigs { get; set; } = null!;
        public virtual DbSet<SuburbDistanceConfigView> SuburbDistanceConfigViews { get; set; } = null!;
        public virtual DbSet<SystemEventLog> SystemEventLogs { get; set; } = null!;
        public virtual DbSet<SystemPermission> SystemPermissions { get; set; } = null!;
        public virtual DbSet<SystemSection> SystemSections { get; set; } = null!;
        public virtual DbSet<SystemSectionUserType> SystemSectionUserTypes { get; set; } = null!;
        public virtual DbSet<TempLocation> TempLocations { get; set; } = null!;
        public virtual DbSet<TempMarleysProductsImport> TempMarleysProductsImports { get; set; } = null!;
        public virtual DbSet<TimeSlot> TimeSlots { get; set; } = null!;
        public virtual DbSet<Tmsapi> Tmsapis { get; set; } = null!;
        public virtual DbSet<TrailerConfiguration> TrailerConfigurations { get; set; } = null!;
        public virtual DbSet<TransactionTable> TransactionTables { get; set; } = null!;
        public virtual DbSet<TripEnquiryView> TripEnquiryViews { get; set; } = null!;
        public virtual DbSet<TripStatus> TripStatuses { get; set; } = null!;
        public virtual DbSet<User> Users { get; set; } = null!;
        public virtual DbSet<UserGroup> UserGroups { get; set; } = null!;
        public virtual DbSet<UserType> UserTypes { get; set; } = null!;
        public virtual DbSet<Vehicle> Vehicles { get; set; } = null!;
        public virtual DbSet<VehicleType> VehicleTypes { get; set; } = null!;
        public virtual DbSet<ViewTemplate> ViewTemplates { get; set; } = null!;
        public virtual DbSet<VwAspnetApplication> VwAspnetApplications { get; set; } = null!;
        public virtual DbSet<VwAspnetMembershipUser> VwAspnetMembershipUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetProfile> VwAspnetProfiles { get; set; } = null!;
        public virtual DbSet<VwAspnetRole> VwAspnetRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetUser> VwAspnetUsers { get; set; } = null!;
        public virtual DbSet<VwAspnetUsersInRole> VwAspnetUsersInRoles { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStatePath> VwAspnetWebPartStatePaths { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateShared> VwAspnetWebPartStateShareds { get; set; } = null!;
        public virtual DbSet<VwAspnetWebPartStateUser> VwAspnetWebPartStateUsers { get; set; } = null!;
        public virtual DbSet<WebPanelUser> WebPanelUsers { get; set; } = null!;
        public virtual DbSet<WebPanelUserCustomer> WebPanelUserCustomers { get; set; } = null!;
        public virtual DbSet<WebPanelUsersType> WebPanelUsersTypes { get; set; } = null!;
        public virtual DbSet<WorkflowKind> WorkflowKinds { get; set; } = null!;
        public virtual DbSet<WorkflowSubKind> WorkflowSubKinds { get; set; } = null!;
        public virtual DbSet<Zone> Zones { get; set; } = null!;
        public virtual DbSet<ZoneType> ZoneTypes { get; set; } = null!;
        public virtual DbSet<ZonesMulti> ZonesMultis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=DESKTOP-JABD5GQ;Database=transfocus-qa-2022-9-26-12-12;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("Account");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<AccountingSystem>(entity =>
            {
                entity.ToTable("AccountingSystem");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<AccountingSystemInstance>(entity =>
            {
                entity.ToTable("AccountingSystemInstance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abn)
                    .HasMaxLength(20)
                    .HasColumnName("ABN");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BusinessName).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.LastCostingSyncDate).HasColumnType("datetime");

                entity.Property(e => e.LastInvoiceSyncDate).HasColumnType("datetime");

                entity.Property(e => e.LastPricingsSyncDate).HasColumnType("datetime");

                entity.Property(e => e.LastSubcontractorInvoiceSyncDate).HasColumnType("datetime");

                entity.Property(e => e.LastSubcontractorSyncDate).HasColumnType("datetime");

                entity.Property(e => e.LastSyncDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PostalAddress).HasMaxLength(50);

                entity.Property(e => e.SystemId)
                    .HasMaxLength(10)
                    .HasColumnName("SystemID");

                entity.Property(e => e.XeroExpiresAtUtc).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AccountingSystemInstances)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_AccountingSystemInstance_Company");

                entity.HasOne(d => d.System)
                    .WithMany(p => p.AccountingSystemInstances)
                    .HasForeignKey(d => d.SystemId)
                    .HasConstraintName("FK_AccountingSystemInstance_AccountingSystemType");
            });

            modelBuilder.Entity<AccountingSystemInterfaceType>(entity =>
            {
                entity.ToTable("AccountingSystemInterfaceType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingSystemId)
                    .HasMaxLength(10)
                    .HasColumnName("AccountingSystemID");

                entity.Property(e => e.InterfaceTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("InterfaceTypeID");

                entity.HasOne(d => d.AccountingSystem)
                    .WithMany(p => p.AccountingSystemInterfaceTypes)
                    .HasForeignKey(d => d.AccountingSystemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountingSystemInterfaceType_AccountingSystem");

                entity.HasOne(d => d.InterfaceType)
                    .WithMany(p => p.AccountingSystemInterfaceTypes)
                    .HasForeignKey(d => d.InterfaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AccountingSystemInterfaceType_InterfaceType");
            });

            modelBuilder.Entity<Activity>(entity =>
            {
                entity.ToTable("Activity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Activities)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Activity_Company");
            });

            modelBuilder.Entity<AfterBookingRoute>(entity =>
            {
                entity.ToTable("AfterBookingRoute");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Route).HasMaxLength(200);
            });

            modelBuilder.Entity<AggregatedCounter>(entity =>
            {
                entity.HasKey(e => e.Key)
                    .HasName("PK_HangFire_CounterAggregated");

                entity.ToTable("AggregatedCounter", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_AggregatedCounter_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Apikey>(entity =>
            {
                entity.ToTable("APIKeys");

                entity.HasIndex(e => e.ApiKey1, "UQ__APIKeys__A4E6E1866CB7C706")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ApiKey1)
                    .HasMaxLength(250)
                    .HasColumnName("ApiKey");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasMaxLength(300);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Apikeys)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__APIKeys__Company__6F00685E");
            });

            modelBuilder.Entity<AspnetApplication>(entity =>
            {
                entity.HasKey(e => e.ApplicationId)
                    .HasName("PK__aspnet_A__C93A4C983B060420")
                    .IsClustered(false);

                entity.ToTable("aspnet_Applications");

                entity.HasIndex(e => e.LoweredApplicationName, "UQ__aspnet_A__17477DE45068FB43")
                    .IsUnique();

                entity.HasIndex(e => e.ApplicationName, "UQ__aspnet_A__3091033121C52DBE")
                    .IsUnique();

                entity.Property(e => e.ApplicationId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspnetMembership>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_M__1788CC4D22200FCE")
                    .IsClustered(false);

                entity.ToTable("aspnet_Membership");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.Password).HasMaxLength(128);

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.PasswordSalt).HasMaxLength(128);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetMemberships)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__Appli__6FF48C97");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetMembership)
                    .HasForeignKey<AspnetMembership>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Me__UserI__70E8B0D0");
            });

            modelBuilder.Entity<AspnetPath>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC5891CFB64B")
                    .IsClustered(false);

                entity.ToTable("aspnet_Paths");

                entity.Property(e => e.PathId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetPaths)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pa__Appli__452A2A23");
            });

            modelBuilder.Entity<AspnetPersonalizationAllUser>(entity =>
            {
                entity.HasKey(e => e.PathId)
                    .HasName("PK__aspnet_P__CD67DC595E0FD9AA");

                entity.ToTable("aspnet_PersonalizationAllUsers");

                entity.Property(e => e.PathId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithOne(p => p.AspnetPersonalizationAllUser)
                    .HasForeignKey<AspnetPersonalizationAllUser>(d => d.PathId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pe__PathI__72D0F942");
            });

            modelBuilder.Entity<AspnetPersonalizationPerUser>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK__aspnet_P__3214EC063E7D3523")
                    .IsClustered(false);

                entity.ToTable("aspnet_PersonalizationPerUser");

                entity.Property(e => e.Id).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PageSettings).HasColumnType("image");

                entity.HasOne(d => d.Path)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.PathId)
                    .HasConstraintName("FK__aspnet_Pe__PathI__73C51D7B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspnetPersonalizationPerUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__aspnet_Pe__UserI__74B941B4");
            });

            modelBuilder.Entity<AspnetProfile>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_P__1788CC4C2A688F18");

                entity.ToTable("aspnet_Profile");

                entity.Property(e => e.UserId).ValueGeneratedNever();

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyNames).HasColumnType("ntext");

                entity.Property(e => e.PropertyValuesBinary).HasColumnType("image");

                entity.Property(e => e.PropertyValuesString).HasColumnType("ntext");

                entity.HasOne(d => d.User)
                    .WithOne(p => p.AspnetProfile)
                    .HasForeignKey<AspnetProfile>(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Pr__UserI__75AD65ED");
            });

            modelBuilder.Entity<AspnetRole>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK__aspnet_R__8AFACE1B4643961A")
                    .IsClustered(false);

                entity.ToTable("aspnet_Roles");

                entity.Property(e => e.RoleId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetRoles)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Ro__Appli__49EEDF40");
            });

            modelBuilder.Entity<AspnetSchemaVersion>(entity =>
            {
                entity.HasKey(e => new { e.Feature, e.CompatibleSchemaVersion })
                    .HasName("PK__aspnet_S__5A1E6BC119EFD626");

                entity.ToTable("aspnet_SchemaVersions");

                entity.Property(e => e.Feature).HasMaxLength(128);

                entity.Property(e => e.CompatibleSchemaVersion).HasMaxLength(128);
            });

            modelBuilder.Entity<AspnetUser>(entity =>
            {
                entity.HasKey(e => e.UserId)
                    .HasName("PK__aspnet_U__1788CC4DCFDBC1C3")
                    .IsClustered(false);

                entity.ToTable("aspnet_Users");

                entity.Property(e => e.UserId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Application)
                    .WithMany(p => p.AspnetUsers)
                    .HasForeignKey(d => d.ApplicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__aspnet_Us__Appli__4AE30379");

                entity.HasMany(d => d.Roles)
                    .WithMany(p => p.Users)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspnetUsersInRole",
                        l => l.HasOne<AspnetRole>().WithMany().HasForeignKey("RoleId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__RoleI__4BD727B2"),
                        r => r.HasOne<AspnetUser>().WithMany().HasForeignKey("UserId").OnDelete(DeleteBehavior.ClientSetNull).HasConstraintName("FK__aspnet_Us__UserI__4CCB4BEB"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId").HasName("PK__aspnet_U__AF2760AD02718A83");

                            j.ToTable("aspnet_UsersInRoles");
                        });
            });

            modelBuilder.Entity<AspnetWebEventEvent>(entity =>
            {
                entity.HasKey(e => e.EventId)
                    .HasName("PK__aspnet_W__7944C810B8DC1776");

                entity.ToTable("aspnet_WebEvent_Events");

                entity.Property(e => e.EventId)
                    .HasMaxLength(32)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.ApplicationPath).HasMaxLength(256);

                entity.Property(e => e.ApplicationVirtualPath).HasMaxLength(256);

                entity.Property(e => e.Details).HasColumnType("ntext");

                entity.Property(e => e.EventOccurrence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventSequence).HasColumnType("decimal(19, 0)");

                entity.Property(e => e.EventTime).HasColumnType("datetime");

                entity.Property(e => e.EventTimeUtc).HasColumnType("datetime");

                entity.Property(e => e.EventType).HasMaxLength(256);

                entity.Property(e => e.ExceptionType).HasMaxLength(256);

                entity.Property(e => e.MachineName).HasMaxLength(256);

                entity.Property(e => e.Message).HasMaxLength(1024);

                entity.Property(e => e.RequestUrl).HasMaxLength(1024);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.FileName).HasMaxLength(200);

                entity.Property(e => e.FileType).HasMaxLength(30);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy).HasMaxLength(50);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Attachments)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Attachment_Job");
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.ToTable("AuditLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.IpAddress).HasMaxLength(150);

                entity.Property(e => e.PrimaryKeyId)
                    .HasMaxLength(150)
                    .HasColumnName("PrimaryKeyID");

                entity.Property(e => e.State).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(150);

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.UserId)
                    .HasMaxLength(150)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<AuthToken>(entity =>
            {
                entity.HasKey(e => e.Token);

                entity.ToTable("AuthToken");

                entity.Property(e => e.Token).ValueGeneratedNever();

                entity.Property(e => e.AndroidVersion).HasMaxLength(20);

                entity.Property(e => e.AppVersion).HasMaxLength(10);

                entity.Property(e => e.BreakEndTime).HasColumnType("datetime");

                entity.Property(e => e.BreakStartTime).HasColumnType("datetime");

                entity.Property(e => e.DeviceId).HasColumnName("DeviceID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.GcmregistrationId).HasColumnName("GCMRegistrationID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.AuthTokens)
                    .HasForeignKey(d => d.DeviceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthToken_MobileDevice");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AuthTokens)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AuthToken_User");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.AuthTokens)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_AuthToken_Vehicle");
            });

            modelBuilder.Entity<AutomaticEdilog>(entity =>
            {
                entity.ToTable("AutomaticEDILog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FileUrl)
                    .HasColumnName("FileURL")
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.FormatId).HasColumnName("FormatID");

                entity.Property(e => e.ImportTypeId).HasColumnName("ImportTypeID");

                entity.Property(e => e.LogFileUrl).HasColumnName("LogFileURL");

                entity.Property(e => e.ProcessedTimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.AutomaticEdilogs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AutomaticEDILog_Company");

                entity.HasOne(d => d.Format)
                    .WithMany(p => p.AutomaticEdilogs)
                    .HasForeignKey(d => d.FormatId)
                    .HasConstraintName("FK_AutomaticEDILog_JobImportMode");

                entity.HasOne(d => d.ImportType)
                    .WithMany(p => p.AutomaticEdilogs)
                    .HasForeignKey(d => d.ImportTypeId)
                    .HasConstraintName("FK_AutomaticEDILog_ImportTypeID");
            });

            modelBuilder.Entity<AvailableServiceCode>(entity =>
            {
                entity.ToTable("AvailableServiceCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClientId)
                    .HasMaxLength(50)
                    .HasColumnName("ClientID");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.AvailableServiceCodes)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .HasConstraintName("FK__Available__Servi__011F1899");
            });

            modelBuilder.Entity<BookingPrintOption>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerCnote).HasColumnName("CustomerCNote");

                entity.Property(e => e.EmailCustomerCnote).HasColumnName("EmailCustomerCNote");

                entity.Property(e => e.EmailUserCnote).HasColumnName("EmailUserCNote");

                entity.Property(e => e.EmailUserPod).HasColumnName("EmailUserPOD");

                entity.Property(e => e.UserCnote).HasColumnName("UserCNote");

                entity.Property(e => e.UserPod).HasColumnName("UserPOD");
            });

            modelBuilder.Entity<BookingTemplate>(entity =>
            {
                entity.ToTable("BookingTemplate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ViewName).HasMaxLength(50);
            });

            modelBuilder.Entity<BottleTrack>(entity =>
            {
                entity.ToTable("BottleTrack");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.BottleTracks)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BottleTrack_JobLeg");
            });

            modelBuilder.Entity<BottleTrackShippingUnit>(entity =>
            {
                entity.ToTable("BottleTrackShippingUnit");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BottleTrackId).HasColumnName("BottleTrackID");

                entity.Property(e => e.EmptyQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.BottleTrack)
                    .WithMany(p => p.BottleTrackShippingUnits)
                    .HasForeignKey(d => d.BottleTrackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_BottleTrackShippingUnit_BottleTrack");
            });

            modelBuilder.Entity<CheckList>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CheckLists)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CheckLists_Company");
            });

            modelBuilder.Entity<CheckListsHistory>(entity =>
            {
                entity.ToTable("CheckListsHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CheckListsId).HasColumnName("CheckListsID");

                entity.Property(e => e.Note).HasMaxLength(500);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.CheckLists)
                    .WithMany(p => p.CheckListsHistories)
                    .HasForeignKey(d => d.CheckListsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CheckListsHistory_CheckLists");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.ToTable("Company");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abn)
                    .HasMaxLength(50)
                    .HasColumnName("ABN");

                entity.Property(e => e.AccountingSystemId)
                    .HasMaxLength(10)
                    .HasColumnName("AccountingSystemID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.AdminPin).HasColumnName("AdminPIN");

                entity.Property(e => e.AfterBookingRouteId).HasColumnName("AfterBookingRouteID");

                entity.Property(e => e.AllLegsPodareJobPods)
                    .HasColumnName("AllLegsPODareJobPODS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.AllowDistrfromCustomerDl).HasColumnName("AllowDISTRFromCustomerDL");

                entity.Property(e => e.AllowMultipleJobs)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AllowPricingConfirmationJobStatusId).HasColumnName("AllowPricingConfirmationJobStatusID");

                entity.Property(e => e.AttachSpod).HasColumnName("AttachSPOD");

                entity.Property(e => e.BackupSyncFrequency).HasDefaultValueSql("((5))");

                entity.Property(e => e.BeyondDate).HasColumnType("date");

                entity.Property(e => e.BookingFormButtonsPosition).HasDefaultValueSql("((3))");

                entity.Property(e => e.BookingFormInPodapp).HasColumnName("BookingFormInPODApp");

                entity.Property(e => e.BookingPrintOptionsId).HasColumnName("BookingPrintOptionsID");

                entity.Property(e => e.BookingScreenTemplateId).HasColumnName("BookingScreenTemplateID");

                entity.Property(e => e.BookingTemplateId).HasColumnName("BookingTemplateID");

                entity.Property(e => e.BouncedDebugEmail).HasMaxLength(50);

                entity.Property(e => e.Bpaynumber).HasColumnName("BPAYNumber");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CloseOffDate).HasColumnType("date");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.ConnoteTemplateId).HasColumnName("ConnoteTemplateID");

                entity.Property(e => e.ConsignmentsLabel)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CourierShowEtabuttonCustomer).HasColumnName("CourierShowETAButtonCustomer");

                entity.Property(e => e.CourierShowEtabuttonDepot).HasColumnName("CourierShowETAButtonDepot");

                entity.Property(e => e.CreditNotePrefix).HasMaxLength(10);

                entity.Property(e => e.CreditNoteStartingNumber).HasDefaultValueSql("((100))");

                entity.Property(e => e.CubicWeightConvRate).HasDefaultValueSql("((250))");

                entity.Property(e => e.CubicWeightConvRateId).HasColumnName("CubicWeightConvRateID");

                entity.Property(e => e.CustomBookingEmail).HasMaxLength(200);

                entity.Property(e => e.CustomBookingMessage).HasMaxLength(50);

                entity.Property(e => e.CustomTextForJobRef).HasMaxLength(50);

                entity.Property(e => e.DebugEmail).HasMaxLength(100);

                entity.Property(e => e.DebugEmailEdi).HasColumnName("DebugEmailEDI");

                entity.Property(e => e.DefMapReloadTime).HasDefaultValueSql("((30))");

                entity.Property(e => e.DefaultDepotId).HasColumnName("DefaultDepotID");

                entity.Property(e => e.DefaultJobKindId)
                    .HasMaxLength(5)
                    .HasColumnName("DefaultJobKindID");

                entity.Property(e => e.DefaultJobSourceId).HasColumnName("DefaultJobSourceID");

                entity.Property(e => e.DefaultJobStatusIdforClientUsers)
                    .HasMaxLength(10)
                    .HasColumnName("DefaultJobStatusIDForClientUsers")
                    .HasDefaultValueSql("(N'VER')");

                entity.Property(e => e.DefaultManifestType).HasMaxLength(200);

                entity.Property(e => e.DefaultPalletType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.DefaultServiceId).HasColumnName("DefaultServiceID");

                entity.Property(e => e.DefaultTripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("DefaultTripStatusID");

                entity.Property(e => e.DeliveryShowEtabuttonCustomer).HasColumnName("DeliveryShowETAButtonCustomer");

                entity.Property(e => e.DeliveryShowEtabuttonDepot).HasColumnName("DeliveryShowETAButtonDepot");

                entity.Property(e => e.Division).HasMaxLength(20);

                entity.Property(e => e.DropboxSecret).HasMaxLength(50);

                entity.Property(e => e.DropboxToken).HasMaxLength(200);

                entity.Property(e => e.EdiautoLeg).HasColumnName("EDIAutoLeg");

                entity.Property(e => e.EdiautoManifest).HasColumnName("EDIAutoManifest");

                entity.Property(e => e.Email).HasMaxLength(100);

                entity.Property(e => e.EmailAttachmentDeletionFrequency).HasDefaultValueSql("((0))");

                entity.Property(e => e.EmailSenderReplyToMail).HasMaxLength(100);

                entity.Property(e => e.EmailSenderTitle).HasMaxLength(100);

                entity.Property(e => e.EnableGoogleMapsForManifest).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableGoogleMapsForNewLocationCreation).HasDefaultValueSql("((0))");

                entity.Property(e => e.EnableGpshistory).HasColumnName("EnableGPSHistory");

                entity.Property(e => e.EnterProductWeightAndCubicAsTotal).HasDefaultValueSql("((0))");

                entity.Property(e => e.ExportInvoiceTemplateId).HasColumnName("ExportInvoiceTemplateID");

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.ForceLogoutTimeout).HasDefaultValueSql("((30))");

                entity.Property(e => e.FoxProExportPod).HasColumnName("FoxProExportPOD");

                entity.Property(e => e.FoxProUrl).HasMaxLength(200);

                entity.Property(e => e.Ftppassword)
                    .HasMaxLength(50)
                    .HasColumnName("FTPPassword");

                entity.Property(e => e.Ftpserver)
                    .HasMaxLength(100)
                    .HasColumnName("FTPServer");

                entity.Property(e => e.Ftpusername)
                    .HasMaxLength(50)
                    .HasColumnName("FTPUsername");

                entity.Property(e => e.Gpsfrequency).HasColumnName("GPSFrequency");

                entity.Property(e => e.GpssendFrequency)
                    .HasColumnName("GPSSendFrequency")
                    .HasDefaultValueSql("((300))");

                entity.Property(e => e.GroupLabels).IsUnicode(false);

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.InterfaceTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("InterfaceTypeID");

                entity.Property(e => e.InterfaceVersionId)
                    .HasMaxLength(10)
                    .HasColumnName("InterfaceVersionID");

                entity.Property(e => e.InvoiceAttachPod).HasColumnName("InvoiceAttachPOD");

                entity.Property(e => e.InvoiceCopyEmail).HasMaxLength(100);

                entity.Property(e => e.InvoiceDeliveryMethodId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceDeliveryMethodID");

                entity.Property(e => e.InvoiceGstdirectCalc).HasColumnName("InvoiceGSTdirectCalc");

                entity.Property(e => e.InvoiceNumberPrefix)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'INV')");

                entity.Property(e => e.InvoiceStartingNumber).HasDefaultValueSql("((100))");

                entity.Property(e => e.InvoiceTemplateId)
                    .HasColumnName("InvoiceTemplateID")
                    .HasDefaultValueSql("((2))");

                entity.Property(e => e.InvoicingFrequencyId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoicingFrequencyID")
                    .HasDefaultValueSql("(N'ANY')");

                entity.Property(e => e.InvoicingGroupingId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoicingGroupingID")
                    .HasDefaultValueSql("(N'ONE')");

                entity.Property(e => e.IsCustomerNameUnique)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.IsEtamandatory).HasColumnName("IsETAMandatory");

                entity.Property(e => e.IsEtavisible).HasColumnName("IsETAVisible");

                entity.Property(e => e.IsLocationAvailableToLegs).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsTms).HasColumnName("IsTMS");

                entity.Property(e => e.JobImportModeId).HasColumnName("JobImportModeID");

                entity.Property(e => e.JobLegColumnOrder).HasMaxLength(500);

                entity.Property(e => e.JobNumberPrefix).HasMaxLength(10);

                entity.Property(e => e.JobNumberStartIndex).HasDefaultValueSql("((1000))");

                entity.Property(e => e.JobWeightType).HasMaxLength(10);

                entity.Property(e => e.LabelTemplateId)
                    .HasColumnName("LabelTemplateID")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.LastWriteIntervalSeconds).HasDefaultValueSql("((10000))");

                entity.Property(e => e.LegCreationMethod).HasMaxLength(10);

                entity.Property(e => e.LegValidationMethod).HasMaxLength(50);

                entity.Property(e => e.LinehaulShowEtabuttonCustomer).HasColumnName("LinehaulShowETAButtonCustomer");

                entity.Property(e => e.LinehaulShowEtabuttonDepot).HasColumnName("LinehaulShowETAButtonDepot");

                entity.Property(e => e.MandatoryGroupingOfCostItems)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.MandatoryGroupingOfPriceItems)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ManifestNumberLastIndex).HasDefaultValueSql("((0))");

                entity.Property(e => e.ManifestNumberPrefix).HasMaxLength(20);

                entity.Property(e => e.ManifestReportId)
                    .HasColumnName("ManifestReportID")
                    .HasDefaultValueSql("((28))");

                entity.Property(e => e.ManifestTotalsLogicClass).HasMaxLength(200);

                entity.Property(e => e.MapDefaultCentreId).HasColumnName("MapDefaultCentreID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.PaymentPrefix).HasMaxLength(10);

                entity.Property(e => e.PaymentStartingNumber).HasDefaultValueSql("((100))");

                entity.Property(e => e.PaymentTermsEop).HasColumnName("PaymentTermsEOP");

                entity.Property(e => e.PaymentTermsEopnewCustomer).HasColumnName("PaymentTermsEOPNewCustomer");

                entity.Property(e => e.PaymentTermsId)
                    .HasMaxLength(10)
                    .HasColumnName("PaymentTermsID");

                entity.Property(e => e.PaymentTermsNewCustomer).HasMaxLength(10);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PickupShowEtabuttonCustomer).HasColumnName("PickupShowETAButtonCustomer");

                entity.Property(e => e.PickupShowEtabuttonDepot).HasColumnName("PickupShowETAButtonDepot");

                entity.Property(e => e.PodexceptionPhotos).HasColumnName("PODExceptionPhotos");

                entity.Property(e => e.Podfooter).HasColumnName("PODFooter");

                entity.Property(e => e.PodtemplateId).HasColumnName("PODTemplateID");

                entity.Property(e => e.PostalAddress).HasMaxLength(50);

                entity.Property(e => e.PostalPostCode).HasMaxLength(10);

                entity.Property(e => e.PostalStateId)
                    .HasMaxLength(10)
                    .HasColumnName("PostalStateID");

                entity.Property(e => e.PostalSuburbId).HasColumnName("PostalSuburbID");

                entity.Property(e => e.Postcode).HasMaxLength(50);

                entity.Property(e => e.PricingQuickFeatures).HasMaxLength(200);

                entity.Property(e => e.PrintPodsignatures)
                    .IsRequired()
                    .HasColumnName("PrintPODSignatures")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ProductCustomFieldLabel01).HasMaxLength(50);

                entity.Property(e => e.ProductCustomFieldLabel02).HasMaxLength(50);

                entity.Property(e => e.ProductCustomFieldLabel03).HasMaxLength(50);

                entity.Property(e => e.ProductCustomFieldLabel04).HasMaxLength(50);

                entity.Property(e => e.ProductCustomFieldLabel05).HasMaxLength(50);

                entity.Property(e => e.ProductDimensionEntry)
                    .HasMaxLength(4)
                    .HasDefaultValueSql("(N'M')");

                entity.Property(e => e.ProductWeightEntry).HasMaxLength(4);

                entity.Property(e => e.RecipientLabel).HasMaxLength(50);

                entity.Property(e => e.Reference10Title).HasMaxLength(100);

                entity.Property(e => e.Reference1Title).HasMaxLength(100);

                entity.Property(e => e.Reference2Title).HasMaxLength(100);

                entity.Property(e => e.Reference3Title).HasMaxLength(100);

                entity.Property(e => e.Reference4Title).HasMaxLength(100);

                entity.Property(e => e.Reference5Title).HasMaxLength(100);

                entity.Property(e => e.Reference6Title).HasMaxLength(100);

                entity.Property(e => e.Reference7Title).HasMaxLength(100);

                entity.Property(e => e.Reference8Title).HasMaxLength(100);

                entity.Property(e => e.Reference9Title).HasMaxLength(100);

                entity.Property(e => e.RemittanceMail).HasMaxLength(50);

                entity.Property(e => e.RequireCustomerPodpaperwork).HasColumnName("RequireCustomerPODpaperwork");

                entity.Property(e => e.RequirePod).HasColumnName("RequirePOD");

                entity.Property(e => e.RequirePodbeforeInvoicing).HasColumnName("RequirePODbeforeInvoicing");

                entity.Property(e => e.ScheduleDropboxPodupload).HasColumnName("ScheduleDropboxPODUpload");

                entity.Property(e => e.SendFailedPodemail)
                    .IsRequired()
                    .HasColumnName("SendFailedPODEmail")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendInvoiceMethodId)
                    .HasMaxLength(10)
                    .HasColumnName("SendInvoiceMethodID");

                entity.Property(e => e.SendInvoicesTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Customer Contacts')");

                entity.Property(e => e.SendIssuesPodemail)
                    .IsRequired()
                    .HasColumnName("SendIssuesPODEmail")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SendPodtoCentralEmailAddress).HasColumnName("SendPODToCentralEmailAddress");

                entity.Property(e => e.SendSuccessPodemail).HasColumnName("SendSuccessPODEmail");

                entity.Property(e => e.SenderLabel).HasMaxLength(50);

                entity.Property(e => e.ShowDateFieldsOnCustomerBooking).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowDepotZoneWarningOnBookingScreen)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowDgcheckBox).HasColumnName("ShowDGCheckBox");

                entity.Property(e => e.ShowDocumentsToCustomerUser)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowDocumentsToMultiCustomerUser)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowDriverTimePicker).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowDriverWorkingTimeOnApp).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowFoxProCodes)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowJobKindOnBooking)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowNavigationToDriver).HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowPodbutton).HasColumnName("ShowPODButton");

                entity.Property(e => e.ShowProductSummaryInJobLegsList)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ShowSendEdi).HasColumnName("ShowSendEDI");

                entity.Property(e => e.ShowShippingUnits)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SpainvoiceTemplateId)
                    .HasColumnName("SPAInvoiceTemplateID")
                    .HasDefaultValueSql("((19))");

                entity.Property(e => e.SpanumberPrefix)
                    .HasMaxLength(50)
                    .HasColumnName("SPANumberPrefix");

                entity.Property(e => e.SpastartingNumber)
                    .HasColumnName("SPAStartingNumber")
                    .HasDefaultValueSql("((100))");

                entity.Property(e => e.SplitExpenseRulesId)
                    .HasMaxLength(10)
                    .HasColumnName("SplitExpenseRulesID");

                entity.Property(e => e.SplitPriceByLegRule).HasDefaultValueSql("((0))");

                entity.Property(e => e.SplitPriceRulesId)
                    .HasMaxLength(10)
                    .HasColumnName("SplitPriceRulesID");

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.StripePublishableKey).HasMaxLength(500);

                entity.Property(e => e.StripeSecretKey).HasMaxLength(500);

                entity.Property(e => e.Subdomain).HasMaxLength(50);

                entity.Property(e => e.SummarizeCostingsOnSpalevel).HasColumnName("SummarizeCostingsOnSPALevel");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.TimerIntervalSeconds).HasDefaultValueSql("((5000))");

                entity.Property(e => e.Timezone).HasMaxLength(100);

                entity.Property(e => e.TinyUrlAuthToken).HasMaxLength(100);

                entity.Property(e => e.Tmstoken).HasColumnName("TMSToken");

                entity.Property(e => e.Tmsurl)
                    .HasMaxLength(200)
                    .HasColumnName("TMSUrl");

                entity.Property(e => e.TwilioAccountSid)
                    .HasMaxLength(100)
                    .HasColumnName("TwilioAccountSID");

                entity.Property(e => e.TwilioAuthToken).HasMaxLength(100);

                entity.Property(e => e.TwilioFromNumber).HasMaxLength(100);

                entity.Property(e => e.UploadPodcustomerFolderDropbox).HasColumnName("UploadPODCustomerFolderDropbox");

                entity.Property(e => e.UploadPoddefaultFolderDropbox).HasColumnName("UploadPODDefaultFolderDropbox");

                entity.Property(e => e.UploadPoddropbox).HasColumnName("UploadPODDropbox");

                entity.Property(e => e.UseCustomCss).HasColumnName("UseCustomCSS");

                entity.Property(e => e.UseCustomEdifolderDropbox).HasColumnName("UseCustomEDIFolderDropbox");

                entity.Property(e => e.UseCustomerDueTimestamp)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UseFoxPro).HasDefaultValueSql("((0))");

                entity.Property(e => e.UseFtp).HasColumnName("UseFTP");

                entity.Property(e => e.UseInvoiceExport)
                    .IsRequired()
                    .HasDefaultValueSql("('0')");

                entity.Property(e => e.UseModernDateTimePicker)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.UsePodphotographs).HasColumnName("UsePODPhotographs");

                entity.Property(e => e.UsedTolls).HasMaxLength(200);

                entity.Property(e => e.Version).HasDefaultValueSql("((1))");

                entity.Property(e => e.WebServiceUrl).HasColumnName("WebServiceURL");

                entity.Property(e => e.Website).HasMaxLength(100);

                entity.Property(e => e.XeroAccountCodePrefix).HasMaxLength(10);

                entity.Property(e => e.XeroClientId)
                    .HasMaxLength(250)
                    .HasColumnName("XeroClientID");

                entity.Property(e => e.XeroClientSecret).HasMaxLength(250);

                entity.Property(e => e.XeroSyncTmscustomersWithXero).HasColumnName("XeroSyncTMSCustomersWithXero");

                entity.Property(e => e.XeroSyncTmspricingsWithXero).HasColumnName("XeroSyncTMSPricingsWithXero");

                entity.Property(e => e.XeroSyncXeroPricingsWithTms).HasColumnName("XeroSyncXeroPricingsWithTMS");

                entity.HasOne(d => d.AccountingSystem)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.AccountingSystemId)
                    .HasConstraintName("FK_Company_AccountingSystem");

                entity.HasOne(d => d.AfterBookingRoute)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.AfterBookingRouteId)
                    .HasConstraintName("FK_Company_AfterBookingRoute");

                entity.HasOne(d => d.BookingPrintOptions)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.BookingPrintOptionsId)
                    .HasConstraintName("FK__Company__Booking__06D7F1EF");

                entity.HasOne(d => d.BookingScreenTemplate)
                    .WithMany(p => p.CompanyBookingScreenTemplates)
                    .HasForeignKey(d => d.BookingScreenTemplateId)
                    .HasConstraintName("FK_Company_ViewTemplate");

                entity.HasOne(d => d.BookingTemplate)
                    .WithMany(p => p.CompanyBookingTemplates)
                    .HasForeignKey(d => d.BookingTemplateId)
                    .HasConstraintName("FK_Company_BookingTemplate");

                entity.HasOne(d => d.ConnoteTemplate)
                    .WithMany(p => p.CompanyConnoteTemplates)
                    .HasForeignKey(d => d.ConnoteTemplateId)
                    .HasConstraintName("FK_Company_Report3");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Country");

                entity.HasOne(d => d.CubicWeightConvRateNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.CubicWeightConvRateId)
                    .HasConstraintName("FK__Company__CubicWe__08C03A61");

                entity.HasOne(d => d.DefaultDepot)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.DefaultDepotId)
                    .HasConstraintName("FKM_Company_Depot");

                entity.HasOne(d => d.DefaultJobSource)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.DefaultJobSourceId)
                    .HasConstraintName("FK_Company_JobSource");

                entity.HasOne(d => d.DefaultTripStatus)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.DefaultTripStatusId)
                    .HasConstraintName("FK_Company_TripStatus");

                entity.HasOne(d => d.Gstcode)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.GstcodeId)
                    .HasConstraintName("FK_Company_GSTCode");

                entity.HasOne(d => d.InterfaceType)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.InterfaceTypeId)
                    .HasConstraintName("FK_Company_InterfaceType");

                entity.HasOne(d => d.InterfaceVersion)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.InterfaceVersionId)
                    .HasConstraintName("FK_Company_InterfaceVersion");

                entity.HasOne(d => d.InvoiceDeliveryMethod)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.InvoiceDeliveryMethodId)
                    .HasConstraintName("FK_Company_InvoiceDeliveryMethod");

                entity.HasOne(d => d.InvoiceTemplate)
                    .WithMany(p => p.CompanyInvoiceTemplates)
                    .HasForeignKey(d => d.InvoiceTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Report1");

                entity.HasOne(d => d.InvoicingFrequency)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.InvoicingFrequencyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_InvoicingFrequency");

                entity.HasOne(d => d.InvoicingGrouping)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.InvoicingGroupingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_InvoicingGrouping");

                entity.HasOne(d => d.JobImportMode)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.JobImportModeId)
                    .HasConstraintName("FK_Company_JobImportMode");

                entity.HasOne(d => d.LabelTemplate)
                    .WithMany(p => p.CompanyLabelTemplates)
                    .HasForeignKey(d => d.LabelTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Report");

                entity.HasOne(d => d.LegCreationMethodNavigation)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.LegCreationMethod)
                    .HasConstraintName("FK_Company_LegCreationMethod");

                entity.HasOne(d => d.ManifestReport)
                    .WithMany(p => p.CompanyManifestReports)
                    .HasForeignKey(d => d.ManifestReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_ManifestReportID");

                entity.HasOne(d => d.MapDefaultCentre)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.MapDefaultCentreId)
                    .HasConstraintName("FK_Company_MapDefaultCentre");

                entity.HasOne(d => d.PaymentTerms)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.PaymentTermsId)
                    .HasConstraintName("FK_Company_PaymentTerms");

                entity.HasOne(d => d.Podtemplate)
                    .WithMany(p => p.CompanyPodtemplates)
                    .HasForeignKey(d => d.PodtemplateId)
                    .HasConstraintName("FK_Company_Report2");

                entity.HasOne(d => d.PostalState)
                    .WithMany(p => p.CompanyPostalStates)
                    .HasForeignKey(d => d.PostalStateId)
                    .HasConstraintName("FK_Company_State1");

                entity.HasOne(d => d.PostalSuburb)
                    .WithMany(p => p.CompanyPostalSuburbs)
                    .HasForeignKey(d => d.PostalSuburbId)
                    .HasConstraintName("FK_Company_Suburbs1");

                entity.HasOne(d => d.SendInvoiceMethod)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.SendInvoiceMethodId)
                    .HasConstraintName("FK_Company_SendInvoiceMethod");

                entity.HasOne(d => d.SplitExpenseRules)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.SplitExpenseRulesId)
                    .HasConstraintName("FK__Company__SplitEx__05E3CDB6");

                entity.HasOne(d => d.SplitPriceRules)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.SplitPriceRulesId)
                    .HasConstraintName("FK__Company__SplitPr__07CC1628");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.CompanyStateNavigations)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_Company_State");

                entity.HasOne(d => d.SuburbNavigation)
                    .WithMany(p => p.CompanySuburbNavigations)
                    .HasForeignKey(d => d.Suburb)
                    .HasConstraintName("FK_Company_Suburbs");
            });

            modelBuilder.Entity<CompanyCompliance>(entity =>
            {
                entity.ToTable("CompanyCompliance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Class).HasMaxLength(100);

                entity.Property(e => e.Comment).HasMaxLength(500);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ComplianceId).HasColumnName("ComplianceID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.EffectiveDate).HasColumnType("datetime");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.FleetId).HasColumnName("FleetID");

                entity.Property(e => e.LicenceNo).HasMaxLength(100);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyCompliances)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyCompliance_Company");

                entity.HasOne(d => d.Compliance)
                    .WithMany(p => p.CompanyCompliances)
                    .HasForeignKey(d => d.ComplianceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyCompliance_Compliance");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.CompanyCompliances)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_CompanyCompliance_User");

                entity.HasOne(d => d.Fleet)
                    .WithMany(p => p.CompanyCompliances)
                    .HasForeignKey(d => d.FleetId)
                    .HasConstraintName("FK_CompanyCompliance_FleetAsset");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.CompanyCompliances)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_CompanyCompliance_Subcontractors");
            });

            modelBuilder.Entity<CompanyHistory>(entity =>
            {
                entity.ToTable("CompanyHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyHistories)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyHistory_Company");
            });

            modelBuilder.Entity<CompanyToll>(entity =>
            {
                entity.HasIndex(e => e.CompanyId, "IX_FK_CompanyTollsCompany");

                entity.HasIndex(e => e.GeneralTollsId, "IX_FK_CompanyTollsGeneralTolls");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.GeneralTollsId).HasColumnName("GeneralTollsID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CompanyTolls)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyTollsCompany");

                entity.HasOne(d => d.GeneralTolls)
                    .WithMany(p => p.CompanyTolls)
                    .HasForeignKey(d => d.GeneralTollsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CompanyTollsGeneralTolls");
            });

            modelBuilder.Entity<Compliance>(entity =>
            {
                entity.ToTable("Compliance");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ComplianceTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("ComplianceTypeID");

                entity.Property(e => e.FleetAssetSubtypeId).HasColumnName("FleetAssetSubtypeID");

                entity.Property(e => e.FleetAssetTypeId).HasColumnName("FleetAssetTypeID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Compliances)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compliance_CompanyID");

                entity.HasOne(d => d.ComplianceType)
                    .WithMany(p => p.Compliances)
                    .HasForeignKey(d => d.ComplianceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Compliance_ComplianceTypeID");

                entity.HasOne(d => d.FleetAssetSubtype)
                    .WithMany(p => p.Compliances)
                    .HasForeignKey(d => d.FleetAssetSubtypeId)
                    .HasConstraintName("FK_Compliance_FleetAssetSubtypeID");

                entity.HasOne(d => d.FleetAssetType)
                    .WithMany(p => p.Compliances)
                    .HasForeignKey(d => d.FleetAssetTypeId)
                    .HasConstraintName("FK_Compliance_FleetAssetTypeID");
            });

            modelBuilder.Entity<ComplianceType>(entity =>
            {
                entity.ToTable("ComplianceType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ConsignmentReportProductView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ConsignmentReportProductView");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<ConsignmentReportView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ConsignmentReportView");

                entity.Property(e => e.ArrivedReceiverTimestamp).HasColumnType("datetime");

                entity.Property(e => e.ArrivedSenderTimestamp).HasColumnType("datetime");

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.ConsignmentNumber).HasMaxLength(50);

                entity.Property(e => e.ConsignmentReference).HasMaxLength(50);

                entity.Property(e => e.ContactName).HasMaxLength(200);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.DepartedReceiverTimestamp).HasColumnType("datetime");

                entity.Property(e => e.DepartedSenderTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.Expr1).HasMaxLength(100);

                entity.Property(e => e.Expr2).HasMaxLength(100);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.JobKindId)
                    .HasMaxLength(5)
                    .HasColumnName("JobKindID");

                entity.Property(e => e.JobLegTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("JobLegTypeID");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobReference).HasMaxLength(300);

                entity.Property(e => e.JobTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("JobTypeID");

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PodexceptionId)
                    .HasMaxLength(5)
                    .HasColumnName("PODExceptionID");

                entity.Property(e => e.PodexceptionNote).HasColumnName("PODExceptionNote");

                entity.Property(e => e.PodstatusId)
                    .HasMaxLength(5)
                    .HasColumnName("PODStatusID");

                entity.Property(e => e.RecepientPhone).HasMaxLength(50);

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.SignedBy).HasMaxLength(50);

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampAcknowledged).HasColumnType("datetime");

                entity.Property(e => e.TripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("TripStatusID");

                entity.Property(e => e.WorkflowId)
                    .HasMaxLength(5)
                    .HasColumnName("WorkflowID");

                entity.Property(e => e.WorkflowSubId)
                    .HasMaxLength(5)
                    .HasColumnName("WorkflowSubID");
            });

            modelBuilder.Entity<ConsolidatedConsignmentNote>(entity =>
            {
                entity.ToTable("ConsolidatedConsignmentNote");

                entity.HasIndex(e => new { e.CompanyId, e.Date, e.CustomerId, e.ReceiverId, e.DepotId }, "IX_ConsolidatedConsignmentNote");

                entity.HasIndex(e => e.CompanyId, "IX_ConsolidatedConsignmentNote_Company");

                entity.HasIndex(e => new { e.CompanyId, e.Number }, "IX_ConsolidatedConsignmentNote_Number")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.Number).HasMaxLength(50);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ConsolidatedConsignmentNotes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsolidatedConsignmentNote_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ConsolidatedConsignmentNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConsolidatedConsignmentNote_Customer");

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.ConsolidatedConsignmentNoteDepots)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_ConsolidatedConsignmentNote_Location1");

                entity.HasOne(d => d.Receiver)
                    .WithMany(p => p.ConsolidatedConsignmentNoteReceivers)
                    .HasForeignKey(d => d.ReceiverId)
                    .HasConstraintName("FK_ConsolidatedConsignmentNote_Location");
            });

            modelBuilder.Entity<Contact>(entity =>
            {
                entity.ToTable("Contact");

                entity.HasIndex(e => e.FullName, "IX_ContactFullName_ASC");

                entity.HasIndex(e => e.FullName, "IX_ContactFullName_DESC");

                entity.HasIndex(e => new { e.Id, e.CompanyId, e.Active, e.Email }, "_dta_index_Contact_8_1371203985__K1_K11_K7_K4_2_3_5_6_8_9_12_16_17_18_19_20");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.ExportInvoiceTemplateId).HasColumnName("ExportInvoiceTemplateID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FullName).HasMaxLength(500);

                entity.Property(e => e.InvoiceTemplateId).HasColumnName("InvoiceTemplateID");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(450);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PhoneExtension).HasMaxLength(50);

                entity.Property(e => e.Position).HasMaxLength(50);

                entity.Property(e => e.Salutation).HasMaxLength(50);

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .HasColumnName("TypeID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Contact_Company");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Contact_Location");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Contacts)
                    .HasForeignKey(d => d.TypeId)
                    .HasConstraintName("FK_Contact_ContactType");
            });

            modelBuilder.Entity<ContactConfig>(entity =>
            {
                entity.ToTable("ContactConfig");

                entity.HasIndex(e => new { e.SettingId, e.Value, e.ContactId }, "_dta_index_ContactConfig_8_1019202731__K3_K4_K2");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.SettingId).HasColumnName("SettingID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactConfigs)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactConfig_Contact");

                entity.HasOne(d => d.Setting)
                    .WithMany(p => p.ContactConfigs)
                    .HasForeignKey(d => d.SettingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactConfig_ContactSetting");
            });

            modelBuilder.Entity<ContactObject>(entity =>
            {
                entity.ToTable("ContactObject");

                entity.HasIndex(e => e.ContactId, "_dta_index_ContactObject_8_1008774701__K1_2_3_5");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.ObjectId)
                    .HasMaxLength(100)
                    .HasColumnName("ObjectID");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .HasColumnName("TypeID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactObjects)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactObject_Contact");
            });

            modelBuilder.Entity<ContactSetting>(entity =>
            {
                entity.ToTable("ContactSetting");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .HasColumnName("TypeID");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactSettings)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactSetting_ContactType");
            });

            modelBuilder.Entity<ContactType>(entity =>
            {
                entity.ToTable("ContactType");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ContactTypeDetail>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .HasColumnName("TypeID");

                entity.HasOne(d => d.Contact)
                    .WithMany(p => p.ContactTypeDetails)
                    .HasForeignKey(d => d.ContactId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactTypeDetails_Contact");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.ContactTypeDetails)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ContactTypeDetails_ContactType");
            });

            modelBuilder.Entity<ConversationParticipant>(entity =>
            {
                entity.ToTable("ConversationParticipant");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ConversationId).HasColumnName("ConversationID");

                entity.Property(e => e.ParticipantId).HasColumnName("ParticipantID");

                entity.HasOne(d => d.Participant)
                    .WithMany(p => p.ConversationParticipants)
                    .HasForeignKey(d => d.ParticipantId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ConversationParticipant_User");
            });

            modelBuilder.Entity<CostGroup>(entity =>
            {
                entity.ToTable("CostGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CostJobCard>(entity =>
            {
                entity.ToTable("CostJobCard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ServiceLaneId).HasColumnName("ServiceLaneID");

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.CostJobCards)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostJobCard_PricingChargeUnit");

                entity.HasOne(d => d.ServiceLane)
                    .WithMany(p => p.CostJobCards)
                    .HasForeignKey(d => d.ServiceLaneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostJobCard_CostingServiceLane");
            });

            modelBuilder.Entity<CostProductCard>(entity =>
            {
                entity.ToTable("CostProductCard");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.CostingUnitId).HasColumnName("CostingUnitID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ServiceLaneId).HasColumnName("ServiceLaneID");

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.CostProductCards)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostProductCard_PricingChargeUnit");

                entity.HasOne(d => d.CostingUnit)
                    .WithMany(p => p.CostProductCards)
                    .HasForeignKey(d => d.CostingUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostProductCard_Product");

                entity.HasOne(d => d.ServiceLane)
                    .WithMany(p => p.CostProductCards)
                    .HasForeignKey(d => d.ServiceLaneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostProductCard_CostingServiceLane");
            });

            modelBuilder.Entity<CostingOptionalItem>(entity =>
            {
                entity.ToTable("CostingOptionalItem");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.DefaultUnitRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ServiceLaneId).HasColumnName("ServiceLaneID");

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.CostingOptionalItems)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingOptionalItem_PricingChargeUnit");

                entity.HasOne(d => d.CostProductCard)
                    .WithMany(p => p.CostingOptionalItems)
                    .HasForeignKey(d => d.CostProductCardId)
                    .HasConstraintName("FK_CostingOptionalItem_CostProductCard");

                entity.HasOne(d => d.ServiceLane)
                    .WithMany(p => p.CostingOptionalItems)
                    .HasForeignKey(d => d.ServiceLaneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingOptionalItem_CostingServiceLane");
            });

            modelBuilder.Entity<CostingSchedule>(entity =>
            {
                entity.ToTable("CostingSchedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostingScheduleStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("CostingScheduleStatusID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CostingSchedules)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingSchedule_Company");

                entity.HasOne(d => d.CostingScheduleStatus)
                    .WithMany(p => p.CostingSchedules)
                    .HasForeignKey(d => d.CostingScheduleStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingSchedule_CostingScheduleStatus");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.CostingSchedules)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_CostingSchedule_Subcontractors");
            });

            modelBuilder.Entity<CostingScheduleStatus>(entity =>
            {
                entity.ToTable("CostingScheduleStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<CostingServiceLane>(entity =>
            {
                entity.ToTable("CostingServiceLane");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CostingScheduleId).HasColumnName("CostingScheduleID");

                entity.Property(e => e.MinCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.HasOne(d => d.CostingSchedule)
                    .WithMany(p => p.CostingServiceLanes)
                    .HasForeignKey(d => d.CostingScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingServiceLane_CostingSchedule");

                entity.HasOne(d => d.FromCostingZoneNavigation)
                    .WithMany(p => p.CostingServiceLaneFromCostingZoneNavigations)
                    .HasForeignKey(d => d.FromCostingZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingServiceLane_Zone");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.CostingServiceLanes)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingServiceLane_ServiceCode");

                entity.HasOne(d => d.ToCostingZoneNavigation)
                    .WithMany(p => p.CostingServiceLaneToCostingZoneNavigations)
                    .HasForeignKey(d => d.ToCostingZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingServiceLane_Zone1");
            });

            modelBuilder.Entity<CostingStatus>(entity =>
            {
                entity.ToTable("CostingStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Counter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Counter", "HangFire");

                entity.HasIndex(e => e.Key, "CX_HangFire_Counter")
                    .IsClustered();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.Key).HasMaxLength(100);
            });

            modelBuilder.Entity<Country>(entity =>
            {
                entity.ToTable("Country");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<CreditNoteReconciliation>(entity =>
            {
                entity.ToTable("CreditNoteReconciliation");

                entity.HasIndex(e => e.CreditNoteId, "CreditNoteReconciliation_CreditNoteID");

                entity.HasIndex(e => e.InvoiceId, "CreditNoteReconciliation_InvoiceID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AmountReconciled).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreditNoteId).HasColumnName("CreditNoteID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.CreditNote)
                    .WithMany(p => p.CreditNoteReconciliations)
                    .HasForeignKey(d => d.CreditNoteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteReconciliation_CreditNote");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.CreditNoteReconciliations)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteReconciliation_PanelInvoice");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.CreditNoteReconciliations)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_CreditNoteReconciliation_Job");
            });

            modelBuilder.Entity<CreditNoteSalesLedger>(entity =>
            {
                entity.ToTable("CreditNoteSalesLedger");

                entity.HasIndex(e => new { e.AccountNameId, e.Date }, "CreditNoteSalesLedger_CustID_Date");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNameId).HasColumnName("AccountNameID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AmountReconciled).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountRounded).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreditNoteNumber).HasMaxLength(50);

                entity.Property(e => e.CreditNoteStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("CreditNoteStatusID");

                entity.Property(e => e.CreditNoteTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("CreditNoteTypeID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DefaultAccountId).HasColumnName("DefaultAccountID");

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("GST");

                entity.Property(e => e.Nett).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.AccountName)
                    .WithMany(p => p.CreditNoteSalesLedgers)
                    .HasForeignKey(d => d.AccountNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteSL_CustomerAccount");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CreditNoteSalesLedgers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteSL_Company");

                entity.HasOne(d => d.CreditNoteStatus)
                    .WithMany(p => p.CreditNoteSalesLedgers)
                    .HasForeignKey(d => d.CreditNoteStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteSL_PaymentStatus");

                entity.HasOne(d => d.CreditNoteType)
                    .WithMany(p => p.CreditNoteSalesLedgers)
                    .HasForeignKey(d => d.CreditNoteTypeId)
                    .HasConstraintName("FK_CreditSL_PaymentType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CreditNoteSalesLedgers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CreditNoteSL_WebPanelUser");
            });

            modelBuilder.Entity<CubicWeightConversionRate>(entity =>
            {
                entity.ToTable("CubicWeightConversionRate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CubicWeightConversionRates)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Company");
            });

            modelBuilder.Entity<CustomActivity>(entity =>
            {
                entity.ToTable("CustomActivity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DataType).HasMaxLength(200);

                entity.Property(e => e.DisplayTime).HasMaxLength(200);

                entity.Property(e => e.Header).HasMaxLength(200);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PricingCode).HasMaxLength(50);

                entity.Property(e => e.PricingCodeId).HasColumnName("PricingCodeID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomActivities)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_CustomActivity_Customer");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CustomActivities)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_CustomActivity_Location");

                entity.HasOne(d => d.PricingCodeNavigation)
                    .WithMany(p => p.CustomActivities)
                    .HasForeignKey(d => d.PricingCodeId)
                    .HasConstraintName("FK_CustomActivity_Pricing");
            });

            modelBuilder.Entity<CustomActivityPhoto>(entity =>
            {
                entity.ToTable("CustomActivityPhoto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<CustomActivityProduct>(entity =>
            {
                entity.HasKey(e => new { e.Code, e.CompanyId })
                    .HasName("PK__CustomAc__70852B6250777000");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.RetailPrice).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CustomActivityProducts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomActivityProducts_CompanyID");
            });

            modelBuilder.Entity<CustomPage>(entity =>
            {
                entity.ToTable("CustomPage");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Color)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'#3697DB')");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CustomPages)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomPage_Company");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.CustomPages)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomPage_WebPanelUser");
            });

            modelBuilder.Entity<CustomReference>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InternalLabel1).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel10).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel2).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel3).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel4).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel5).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel6).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel7).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel8).HasDefaultValueSql("((0))");

                entity.Property(e => e.InternalLabel9).HasDefaultValueSql("((0))");

                entity.Property(e => e.Reference1).HasMaxLength(100);

                entity.Property(e => e.Reference10).HasMaxLength(100);

                entity.Property(e => e.Reference2).HasMaxLength(100);

                entity.Property(e => e.Reference3).HasMaxLength(100);

                entity.Property(e => e.Reference4).HasMaxLength(100);

                entity.Property(e => e.Reference5).HasMaxLength(100);

                entity.Property(e => e.Reference6).HasMaxLength(100);

                entity.Property(e => e.Reference7).HasMaxLength(100);

                entity.Property(e => e.Reference8).HasMaxLength(100);

                entity.Property(e => e.Reference9).HasMaxLength(100);

                entity.Property(e => e.RequireLabel1).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel10).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel2).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel3).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel4).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel5).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel6).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel7).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel8).HasDefaultValueSql("((0))");

                entity.Property(e => e.RequireLabel9).HasDefaultValueSql("((0))");

                entity.Property(e => e.SubjectId).HasColumnName("SubjectID");
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.ToTable("Customer");

                entity.HasIndex(e => new { e.Id, e.Name }, "NonClusteredIndex-20151221-110200")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Id, e.CompanyId, e.AccountName }, "NonClusteredIndex-20190408-102549");

                entity.HasIndex(e => e.CompanyId, "_dta_index_Customer_22_307532179__K9")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.CompanyId, e.Name }, "_dta_index_Customer_22_307532179__K9_K3_1_2_4_5_6_7_8_10_11_12_13_14_15")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Id, e.AccountingSystemInstanceId }, "_dta_index_Customer_5_194867811__K1_K41_3_9");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abn)
                    .HasMaxLength(50)
                    .HasColumnName("ABN");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.AccountSystemName).HasMaxLength(250);

                entity.Property(e => e.AccountingSystemId).HasColumnName("AccountingSystemID");

                entity.Property(e => e.AccountingSystemInstanceId).HasColumnName("AccountingSystemInstanceID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Alias).HasMaxLength(200);

                entity.Property(e => e.BookingType).HasMaxLength(10);

                entity.Property(e => e.Bpayreference).HasColumnName("BPAYReference");

                entity.Property(e => e.CanEditAdresses)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CanEditProducts)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactName).HasMaxLength(200);

                entity.Property(e => e.ContactPhone).HasMaxLength(50);

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerCodeNew).HasMaxLength(100);

                entity.Property(e => e.CustomerSendInvoicesTo)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Customer Contacts')");

                entity.Property(e => e.DefaultPricingScheduleTypeId).HasColumnName("DefaultPricingScheduleTypeID");

                entity.Property(e => e.DropboxFolder).HasMaxLength(200);

                entity.Property(e => e.ExportInvoiceTemplateId).HasColumnName("ExportInvoiceTemplateID");

                entity.Property(e => e.FoxProStatus)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.InvoiceAttachPod).HasColumnName("InvoiceAttachPOD");

                entity.Property(e => e.InvoiceDeliveryMethodId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceDeliveryMethodID");

                entity.Property(e => e.InvoiceFrequencyId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceFrequencyID");

                entity.Property(e => e.InvoiceReference).HasMaxLength(250);

                entity.Property(e => e.InvoiceTemplateId).HasColumnName("InvoiceTemplateID");

                entity.Property(e => e.InvoicingGroupingId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoicingGroupingID");

                entity.Property(e => e.JobWeightType).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PaymentTermsEop).HasColumnName("PaymentTermsEOP");

                entity.Property(e => e.PaymentTermsId)
                    .HasMaxLength(10)
                    .HasColumnName("PaymentTermsID");

                entity.Property(e => e.PostalLocationId).HasColumnName("PostalLocationID");

                entity.Property(e => e.RequireCustomerPodpaperwork).HasColumnName("RequireCustomerPODpaperwork");

                entity.Property(e => e.RequirePod).HasColumnName("RequirePOD");

                entity.Property(e => e.RequirePodbeforeInvoicing).HasColumnName("RequirePODbeforeInvoicing");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TradingName).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.XeroId).HasColumnName("XeroID");

                entity.HasOne(d => d.AccountingSystemInstance)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.AccountingSystemInstanceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Customer_AccountingSystemInstance");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Customer_Country");

                entity.HasOne(d => d.DefaultPricingScheduleType)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.DefaultPricingScheduleTypeId)
                    .HasConstraintName("FK_Customer_PricingScheduleType");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.CustomerGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_Customer_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.CustomerGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_Customer_Group2");

                entity.HasOne(d => d.Gstcode)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.GstcodeId)
                    .HasConstraintName("FK_Customer_GSTCode");

                entity.HasOne(d => d.InvoiceDeliveryMethod)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.InvoiceDeliveryMethodId)
                    .HasConstraintName("FK_Customer_InvoiceDeliveryMethod");

                entity.HasOne(d => d.InvoiceFrequency)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.InvoiceFrequencyId)
                    .HasConstraintName("FK_Customer_InvoicingFrequency");

                entity.HasOne(d => d.InvoiceTemplate)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.InvoiceTemplateId)
                    .HasConstraintName("FK_Customer_Report");

                entity.HasOne(d => d.InvoicingGrouping)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.InvoicingGroupingId)
                    .HasConstraintName("FK_Customer_InvoicingGrouping");

                entity.HasOne(d => d.PaymentTerms)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PaymentTermsId)
                    .HasConstraintName("FK_Customer_PaymentTerms");

                entity.HasOne(d => d.PostalLocation)
                    .WithMany(p => p.Customers)
                    .HasForeignKey(d => d.PostalLocationId)
                    .HasConstraintName("FK_Customer_Location");
            });

            modelBuilder.Entity<CustomerContact>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerContacts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerContacts_Customer");
            });

            modelBuilder.Entity<CustomerLocation>(entity =>
            {
                entity.ToTable("CustomerLocation");

                entity.HasIndex(e => e.LocationId, "_dta_index_CustomerLocation_22_612913255__K2_1_3_4")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.CustomerLocations)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_CustomerLocation_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerLocations)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerLocation_Customer");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.CustomerLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerLocation_Location");
            });

            modelBuilder.Entity<CustomerNote>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerNotes_Customer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerNotes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerNotes_WebPanelUser");
            });

            modelBuilder.Entity<CustomerPricingNote>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(15)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerPricingNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPricingNotes_Customer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CustomerPricingNotes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerPricingNotes_WebPanelUser");
            });

            modelBuilder.Entity<CustomerProduct>(entity =>
            {
                entity.ToTable("CustomerProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerProduct_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.CustomerProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CustomerProduct_Product");
            });

            modelBuilder.Entity<CustomersEnquiryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("CustomersEnquiryView");

                entity.Property(e => e.ActivePods)
                    .HasMaxLength(4000)
                    .HasColumnName("ActivePODs");

                entity.Property(e => e.AllJobPods).HasColumnName("AllJobPODs");

                entity.Property(e => e.AppPod).HasColumnName("AppPOD");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Customer).HasMaxLength(200);

                entity.Property(e => e.CustomerAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEntity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerInvoicingFrequency).HasMaxLength(50);

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceStatus).HasMaxLength(50);

                entity.Property(e => e.InvoiceStatusColor).HasMaxLength(50);

                entity.Property(e => e.InvoiceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceStatusID");

                entity.Property(e => e.IsCustomerPodrequired).HasColumnName("IsCustomerPODRequired");

                entity.Property(e => e.IsPodrequired).HasColumnName("IsPODRequired");

                entity.Property(e => e.IsPodrequiredBeforeInvoicing).HasColumnName("isPODRequiredBeforeInvoicing");

                entity.Property(e => e.JobBookingType).HasMaxLength(10);

                entity.Property(e => e.JobContact).HasMaxLength(152);

                entity.Property(e => e.JobCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobCubicWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobDate).HasColumnType("datetime");

                entity.Property(e => e.JobDateEntered).HasColumnType("datetime");

                entity.Property(e => e.JobDepot).HasMaxLength(100);

                entity.Property(e => e.JobEnteredBy).HasMaxLength(50);

                entity.Property(e => e.JobExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobImportTypeId)
                    .HasMaxLength(3)
                    .HasColumnName("JobImportTypeID");

                entity.Property(e => e.JobKms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobLegIds).HasColumnName("JobLegIDs");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobPallets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobPriceStatus).HasMaxLength(50);

                entity.Property(e => e.JobPriceStatusColor).HasMaxLength(50);

                entity.Property(e => e.JobPriceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("JobPriceStatusID");

                entity.Property(e => e.JobProductOwner).HasMaxLength(200);

                entity.Property(e => e.JobProfit).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.JobProfitPercentage).HasColumnType("numeric(38, 14)");

                entity.Property(e => e.JobQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobReady).HasColumnType("datetime");

                entity.Property(e => e.JobReadyFromCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobRequired).HasColumnType("datetime");

                entity.Property(e => e.JobRequiredCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobService).HasMaxLength(100);

                entity.Property(e => e.JobSpace).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobStatus).HasMaxLength(50);

                entity.Property(e => e.JobStatusColor).HasMaxLength(20);

                entity.Property(e => e.JobStatusId)
                    .HasMaxLength(3)
                    .HasColumnName("JobStatusID");

                entity.Property(e => e.JobWaiting).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobWeightType).HasMaxLength(10);

                entity.Property(e => e.PodphotoCount).HasColumnName("PODPhotoCount");

                entity.Property(e => e.ReceiverAzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverAZone");

                entity.Property(e => e.ReceiverCzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverCZone");

                entity.Property(e => e.ReceiverDzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverDZone");

                entity.Property(e => e.ReceiverGroup).HasMaxLength(50);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverName).HasMaxLength(100);

                entity.Property(e => e.ReceiverPhone).HasMaxLength(50);

                entity.Property(e => e.ReceiverPostCode).HasMaxLength(10);

                entity.Property(e => e.ReceiverPzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverPZone");

                entity.Property(e => e.ReceiverState).HasMaxLength(10);

                entity.Property(e => e.ReceiverSuburb).HasMaxLength(50);

                entity.Property(e => e.Reference1).HasMaxLength(200);

                entity.Property(e => e.Reference10).HasMaxLength(200);

                entity.Property(e => e.Reference2).HasMaxLength(200);

                entity.Property(e => e.Reference3).HasMaxLength(200);

                entity.Property(e => e.Reference4).HasMaxLength(200);

                entity.Property(e => e.Reference5).HasMaxLength(200);

                entity.Property(e => e.Reference6).HasMaxLength(200);

                entity.Property(e => e.Reference7).HasMaxLength(200);

                entity.Property(e => e.Reference8).HasMaxLength(200);

                entity.Property(e => e.Reference9).HasMaxLength(200);

                entity.Property(e => e.SenderAzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderAZone");

                entity.Property(e => e.SenderCzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderCZone");

                entity.Property(e => e.SenderDzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderDZone");

                entity.Property(e => e.SenderGroup).HasMaxLength(50);

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderName).HasMaxLength(100);

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.SenderPostCode).HasMaxLength(10);

                entity.Property(e => e.SenderPzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderPZone");

                entity.Property(e => e.SenderState).HasMaxLength(10);

                entity.Property(e => e.SenderSuburb).HasMaxLength(50);

                entity.Property(e => e.TrackingCode).HasMaxLength(50);
            });

            modelBuilder.Entity<DebtorNote>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LastContact).HasColumnType("datetime");

                entity.Property(e => e.NextContact).HasColumnType("datetime");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.DebtorNotes)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DebtorNotes_Customer");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DebtorNotes)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_DebtorNotes_WebPanelUser");
            });

            modelBuilder.Entity<DefaultAccount>(entity =>
            {
                entity.ToTable("DefaultAccount");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostCenter).HasMaxLength(50);

                entity.Property(e => e.FinancialStatementType).HasMaxLength(50);

                entity.Property(e => e.Glcode)
                    .HasMaxLength(50)
                    .HasColumnName("GLCode");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Type).HasMaxLength(50);
            });

            modelBuilder.Entity<DeviceCrashLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AndroidVersion).HasMaxLength(20);

                entity.Property(e => e.AppVersion).HasMaxLength(20);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DeviceSerialNumber).HasMaxLength(50);

                entity.Property(e => e.DeviceType).HasMaxLength(50);

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.LogType).HasMaxLength(50);

                entity.Property(e => e.NetworkName).HasMaxLength(50);

                entity.Property(e => e.NetworkType).HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.DeviceCrashLogs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__DeviceCra__Compa__71A7CADF");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.DeviceCrashLogs)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK__DeviceCra__Drive__729BEF18");
            });

            modelBuilder.Entity<DriverSignature>(entity =>
            {
                entity.ToTable("DriverSignature");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AuthToken).HasDefaultValueSql("('ae250706-7c79-4877-a5a7-41afb629de82')");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.AuthTokenNavigation)
                    .WithMany(p => p.DriverSignatures)
                    .HasForeignKey(d => d.AuthToken)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DriverSignature_AuthToken");
            });

            modelBuilder.Entity<DriverWorkingTime>(entity =>
            {
                entity.ToTable("DriverWorkingTime");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BreakEndTime).HasColumnType("datetime");

                entity.Property(e => e.BreakStartTime).HasColumnType("datetime");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.EndTime).HasColumnType("datetime");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.DriverWorkingTimes)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_DriverWorkingTime_Manifest");
            });

            modelBuilder.Entity<Edilog>(entity =>
            {
                entity.ToTable("EDILog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FileName).HasMaxLength(500);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Edilogs)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDILog_Company");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.Edilogs)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDILog_WebPanelUser");
            });

            modelBuilder.Entity<EdilogDetail>(entity =>
            {
                entity.ToTable("EDILogDetails");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EdilogId).HasColumnName("EDILogID");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.HasOne(d => d.Edilog)
                    .WithMany(p => p.EdilogDetails)
                    .HasForeignKey(d => d.EdilogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EDILogDetails_EDILog");
            });

            modelBuilder.Entity<Edipath>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("EDIPath");

                entity.Property(e => e.CheckTimeInterval).HasDefaultValueSql("((5000))");

                entity.Property(e => e.CompanyCode).HasMaxLength(50);

                entity.Property(e => e.MillisecondsSinceLastWrite).HasDefaultValueSql("((10000))");
            });

            modelBuilder.Entity<EmailAttachment>(entity =>
            {
                entity.ToTable("EmailAttachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EmailQueueId).HasColumnName("EmailQueueID");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.FileMediaType).HasMaxLength(100);

                entity.Property(e => e.Filename).HasMaxLength(200);

                entity.Property(e => e.Path).HasMaxLength(200);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.EmailQueue)
                    .WithMany(p => p.EmailAttachments)
                    .HasForeignKey(d => d.EmailQueueId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmailAttachment_EmailAttachment");
            });

            modelBuilder.Entity<EmailAttachmentsCleanUpHistory>(entity =>
            {
                entity.ToTable("EmailAttachmentsCleanUpHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.LastCleanUpDate).HasColumnType("date");
            });

            modelBuilder.Entity<EmailHistory>(entity =>
            {
                entity.ToTable("EmailHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmailId).HasColumnName("EmailID");

                entity.Property(e => e.EmailType).HasMaxLength(50);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.HasOne(d => d.Email)
                    .WithMany(p => p.EmailHistories)
                    .HasForeignKey(d => d.EmailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmailHist__Email__7948ECA7");
            });

            modelBuilder.Entity<EmailQueue>(entity =>
            {
                entity.ToTable("EmailQueue");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttachmentExtension).HasMaxLength(30);

                entity.Property(e => e.AttachmentFileMediaType).HasMaxLength(100);

                entity.Property(e => e.AttachmentFileName).HasMaxLength(500);

                entity.Property(e => e.Cc).HasColumnName("CC");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.LastAttempt).HasColumnType("datetime");

                entity.Property(e => e.LastEventTime).HasColumnType("datetime");

                entity.Property(e => e.RecipientEmail).HasMaxLength(500);

                entity.Property(e => e.ReferenceId).HasColumnName("ReferenceID");

                entity.Property(e => e.SenderEmail).HasMaxLength(50);

                entity.Property(e => e.SgmessageId)
                    .HasMaxLength(250)
                    .HasColumnName("SGMessageID");

                entity.Property(e => e.Sgstatus)
                    .HasMaxLength(50)
                    .HasColumnName("SGStatus");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.EmailQueues)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_EmailQueue_Company");
            });

            modelBuilder.Entity<EmailSmstemplate>(entity =>
            {
                entity.ToTable("EmailSMSTemplate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Subject).HasMaxLength(200);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<EnquiryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("EnquiryView");

                entity.Property(e => e.ActivePods)
                    .HasMaxLength(4000)
                    .HasColumnName("ActivePODs");

                entity.Property(e => e.AllJobPods).HasColumnName("AllJobPODs");

                entity.Property(e => e.AppPod).HasColumnName("AppPOD");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Customer).HasMaxLength(200);

                entity.Property(e => e.CustomerAccount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerEntity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerInvoicingFrequency).HasMaxLength(50);

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.FirstLegManifestNumber).HasMaxLength(50);

                entity.Property(e => e.HasHandwrittenPod).HasColumnName("HasHandwrittenPOD");

                entity.Property(e => e.HasJobPod).HasColumnName("HasJobPOD");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceNo).HasMaxLength(50);

                entity.Property(e => e.InvoiceStatus).HasMaxLength(50);

                entity.Property(e => e.InvoiceStatusColor).HasMaxLength(50);

                entity.Property(e => e.InvoiceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceStatusID");

                entity.Property(e => e.IsCustomerPodrequired).HasColumnName("IsCustomerPODRequired");

                entity.Property(e => e.IsPodrequired).HasColumnName("IsPODRequired");

                entity.Property(e => e.IsPodrequiredBeforeInvoicing).HasColumnName("isPODRequiredBeforeInvoicing");

                entity.Property(e => e.JobBookingType).HasMaxLength(10);

                entity.Property(e => e.JobContact).HasMaxLength(500);

                entity.Property(e => e.JobCost).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.JobCubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobCubicWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobDate).HasColumnType("datetime");

                entity.Property(e => e.JobDateEntered).HasColumnType("datetime");

                entity.Property(e => e.JobDepot).HasMaxLength(100);

                entity.Property(e => e.JobEnteredBy).HasMaxLength(50);

                entity.Property(e => e.JobExpense).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.JobGroup1).HasMaxLength(50);

                entity.Property(e => e.JobGroup2).HasMaxLength(50);

                entity.Property(e => e.JobHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobImportTypeId)
                    .HasMaxLength(3)
                    .HasColumnName("JobImportTypeID");

                entity.Property(e => e.JobKindId)
                    .HasMaxLength(5)
                    .HasColumnName("JobKindID");

                entity.Property(e => e.JobKms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobLegBottleTrack).HasMaxLength(4000);

                entity.Property(e => e.JobLegIds).HasColumnName("JobLegIDs");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobPallets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobPrice).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobPriceStatus).HasMaxLength(50);

                entity.Property(e => e.JobPriceStatusColor).HasMaxLength(50);

                entity.Property(e => e.JobPriceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("JobPriceStatusID");

                entity.Property(e => e.JobProductOwner).HasMaxLength(200);

                entity.Property(e => e.JobProfit).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.JobProfitPercentage).HasColumnType("numeric(38, 14)");

                entity.Property(e => e.JobQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobReady).HasColumnType("datetime");

                entity.Property(e => e.JobReadyFromCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobRequired).HasColumnType("datetime");

                entity.Property(e => e.JobRequiredCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobService).HasMaxLength(100);

                entity.Property(e => e.JobSpace).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobStatus).HasMaxLength(50);

                entity.Property(e => e.JobStatusColor).HasMaxLength(20);

                entity.Property(e => e.JobStatusId)
                    .HasMaxLength(3)
                    .HasColumnName("JobStatusID");

                entity.Property(e => e.JobWaiting).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobWeightType).HasMaxLength(10);

                entity.Property(e => e.PodphotoCount).HasColumnName("PODPhotoCount");

                entity.Property(e => e.PricingType)
                    .HasMaxLength(9)
                    .IsUnicode(false);

                entity.Property(e => e.ReceiverAzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverAZone");

                entity.Property(e => e.ReceiverCzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverCZone");

                entity.Property(e => e.ReceiverDzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverDZone");

                entity.Property(e => e.ReceiverGroup).HasMaxLength(50);

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverLocation).HasMaxLength(500);

                entity.Property(e => e.ReceiverName).HasMaxLength(100);

                entity.Property(e => e.ReceiverPhone).HasMaxLength(50);

                entity.Property(e => e.ReceiverPostCode).HasMaxLength(10);

                entity.Property(e => e.ReceiverPzone)
                    .HasMaxLength(200)
                    .HasColumnName("ReceiverPZone");

                entity.Property(e => e.ReceiverState).HasMaxLength(10);

                entity.Property(e => e.ReceiverSuburb).HasMaxLength(50);

                entity.Property(e => e.Reference1).HasMaxLength(200);

                entity.Property(e => e.Reference10).HasMaxLength(200);

                entity.Property(e => e.Reference2).HasMaxLength(200);

                entity.Property(e => e.Reference3).HasMaxLength(200);

                entity.Property(e => e.Reference4).HasMaxLength(200);

                entity.Property(e => e.Reference5).HasMaxLength(200);

                entity.Property(e => e.Reference6).HasMaxLength(200);

                entity.Property(e => e.Reference7).HasMaxLength(200);

                entity.Property(e => e.Reference8).HasMaxLength(200);

                entity.Property(e => e.Reference9).HasMaxLength(200);

                entity.Property(e => e.SenderAzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderAZone");

                entity.Property(e => e.SenderCzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderCZone");

                entity.Property(e => e.SenderDzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderDZone");

                entity.Property(e => e.SenderGroup).HasMaxLength(50);

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderLocation).HasMaxLength(500);

                entity.Property(e => e.SenderName).HasMaxLength(100);

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.SenderPostCode).HasMaxLength(10);

                entity.Property(e => e.SenderPzone)
                    .HasMaxLength(200)
                    .HasColumnName("SenderPZone");

                entity.Property(e => e.SenderState).HasMaxLength(10);

                entity.Property(e => e.SenderSuburb).HasMaxLength(50);

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.Property(e => e.TrackingCode).HasMaxLength(50);

                entity.Property(e => e.Waiting).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Export>(entity =>
            {
                entity.ToTable("Export");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ExportTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("ExportTypeID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.ExportType)
                    .WithMany(p => p.Exports)
                    .HasForeignKey(d => d.ExportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Export_ExportType");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.Exports)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Export_JobLeg");
            });

            modelBuilder.Entity<ExportType>(entity =>
            {
                entity.ToTable("ExportType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ExportedPayment>(entity =>
            {
                entity.ToTable("ExportedPayment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ExportId).HasColumnName("ExportID");

                entity.Property(e => e.ExportedPaymentId).HasColumnName("ExportedPaymentID");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<ExternalJobStatus>(entity =>
            {
                entity.ToTable("ExternalJobStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.ExternalJobStatuses)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK__ExternalJ__Subco__7D197D8B");
            });

            modelBuilder.Entity<ExternalJobStatusImport>(entity =>
            {
                entity.ToTable("ExternalJobStatusImport");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ExternalJobStatusId).HasColumnName("ExternalJobStatusID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.ExternalJobStatus)
                    .WithMany(p => p.ExternalJobStatusImports)
                    .HasForeignKey(d => d.ExternalJobStatusId)
                    .HasConstraintName("FK__ExternalJ__Exter__7E0DA1C4");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.ExternalJobStatusImports)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK__ExternalJ__JobID__7F01C5FD");
            });

            modelBuilder.Entity<ExternalJobStatusMapping>(entity =>
            {
                entity.ToTable("ExternalJobStatusMapping");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ExternalJobStatusId).HasColumnName("ExternalJobStatusID");

                entity.Property(e => e.InternalTrackStatusId).HasColumnName("InternalTrackStatusID");

                entity.HasOne(d => d.ExternalJobStatus)
                    .WithMany(p => p.ExternalJobStatusMappings)
                    .HasForeignKey(d => d.ExternalJobStatusId)
                    .HasConstraintName("FK_ExternalJobStatusID");

                entity.HasOne(d => d.InternalTrackStatus)
                    .WithMany(p => p.ExternalJobStatusMappings)
                    .HasForeignKey(d => d.InternalTrackStatusId)
                    .HasConstraintName("FK_InternalTrackStatusID");
            });

            modelBuilder.Entity<FinancialStatementType>(entity =>
            {
                entity.ToTable("FinancialStatementType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<FleetAsset>(entity =>
            {
                entity.ToTable("FleetAsset");

                entity.HasIndex(e => e.Id, "_dta_index_FleetAsset_5_1734401348__K1_5");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostGroupId).HasColumnName("CostGroupID");

                entity.Property(e => e.CubicSum).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Excess).HasMaxLength(50);

                entity.Property(e => e.FinanceCompany).HasMaxLength(100);

                entity.Property(e => e.FleetAssetFuelTypeId).HasColumnName("FleetAssetFuelTypeID");

                entity.Property(e => e.FleetAssetMakeId).HasColumnName("FleetAssetMakeID");

                entity.Property(e => e.FleetAssetModelId).HasColumnName("FleetAssetModelID");

                entity.Property(e => e.FleetAssetSubtypeId).HasColumnName("FleetAssetSubtypeID");

                entity.Property(e => e.FleetAssetTypeId).HasColumnName("FleetAssetTypeID");

                entity.Property(e => e.FleetNo).HasMaxLength(8);

                entity.Property(e => e.Gcm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("GCM");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.Gvm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("GVM");

                entity.Property(e => e.InsuranceCompany).HasMaxLength(100);

                entity.Property(e => e.InsuranceCover).HasMaxLength(100);

                entity.Property(e => e.InternalHeight).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InternalLength).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InternalWidth).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.JobCodeId).HasColumnName("JobCodeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Notes).HasMaxLength(500);

                entity.Property(e => e.RegistrationNumber).HasMaxLength(8);

                entity.Property(e => e.SerialNo).HasMaxLength(100);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.SumInsured).HasMaxLength(50);

                entity.Property(e => e.Tare).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.VinNo).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetAsset_Company");

                entity.HasOne(d => d.CostGroup)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.CostGroupId)
                    .HasConstraintName("FK_CostGroupID");

                entity.HasOne(d => d.FleetAssetFuelType)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.FleetAssetFuelTypeId)
                    .HasConstraintName("FK_FleetAsset_FleetAssetFuelType");

                entity.HasOne(d => d.FleetAssetMake)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.FleetAssetMakeId)
                    .HasConstraintName("FK_FleetAsset_FleetAssetMake");

                entity.HasOne(d => d.FleetAssetModel)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.FleetAssetModelId)
                    .HasConstraintName("FK_FleetAsset_FleetAssetModel");

                entity.HasOne(d => d.FleetAssetSubtype)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.FleetAssetSubtypeId)
                    .HasConstraintName("FK_FleetAsset_FleetAssetSubtype");

                entity.HasOne(d => d.FleetAssetType)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.FleetAssetTypeId)
                    .HasConstraintName("FK_FleetAsset_FleetAssetType");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.FleetAssetGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_FleetAsset_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.FleetAssetGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_FleetAsset_Group2");

                entity.HasOne(d => d.JobCode)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.JobCodeId)
                    .HasConstraintName("FK_FleetAsset_JobCode");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_FleetAsset_Location");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.FleetAssets)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_FleetAsset_Subcontractors");
            });

            modelBuilder.Entity<FleetAssetAdditionalDetail>(entity =>
            {
                entity.ToTable("FleetAssetAdditionalDetail");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Category).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FleetAssetId).HasColumnName("FleetAssetID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasMaxLength(100);

                entity.HasOne(d => d.FleetAsset)
                    .WithMany(p => p.FleetAssetAdditionalDetails)
                    .HasForeignKey(d => d.FleetAssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetAssetAdditionalDetail_FleetAsset");
            });

            modelBuilder.Entity<FleetAssetAttachment>(entity =>
            {
                entity.ToTable("FleetAssetAttachment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.FileType).HasMaxLength(30);

                entity.Property(e => e.FleetAssetId).HasColumnName("FleetAssetID");

                entity.Property(e => e.OriginalFilename).HasMaxLength(100);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy).HasMaxLength(50);

                entity.HasOne(d => d.FleetAsset)
                    .WithMany(p => p.FleetAssetAttachments)
                    .HasForeignKey(d => d.FleetAssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetAssetAttachment_FleetAsset");
            });

            modelBuilder.Entity<FleetAssetAxleWeight>(entity =>
            {
                entity.ToTable("FleetAssetAxleWeight");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FleetAssetId).HasColumnName("FleetAssetID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Value).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.FleetAsset)
                    .WithMany(p => p.FleetAssetAxleWeights)
                    .HasForeignKey(d => d.FleetAssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetAssetAxleWeight_FleetAsset");
            });

            modelBuilder.Entity<FleetAssetCapacity>(entity =>
            {
                entity.ToTable("FleetAssetCapacity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CubicSum).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.FleetAssetId).HasColumnName("FleetAssetID");

                entity.Property(e => e.Gcm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("GCM");

                entity.Property(e => e.Gvm)
                    .HasColumnType("decimal(18, 3)")
                    .HasColumnName("GVM");

                entity.Property(e => e.InternalHeight).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InternalLength).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.InternalWidth).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Tare).HasColumnType("decimal(18, 3)");

                entity.HasOne(d => d.FleetAsset)
                    .WithMany(p => p.FleetAssetCapacities)
                    .HasForeignKey(d => d.FleetAssetId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetAssetCapacity_FleetAsset");
            });

            modelBuilder.Entity<FleetAssetFuelType>(entity =>
            {
                entity.ToTable("FleetAssetFuelType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FleetAssetMake>(entity =>
            {
                entity.ToTable("FleetAssetMake");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<FleetAssetModel>(entity =>
            {
                entity.ToTable("FleetAssetModel");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FleetAssetMakeId).HasColumnName("FleetAssetMakeID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.FleetAssetMake)
                    .WithMany(p => p.FleetAssetModels)
                    .HasForeignKey(d => d.FleetAssetMakeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetAssetModel_FleetAssetMake");
            });

            modelBuilder.Entity<FleetAssetSubtype>(entity =>
            {
                entity.ToTable("FleetAssetSubtype");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AddedBy).HasMaxLength(50);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FleetAssetTypeId).HasColumnName("FleetAssetTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.FleetAssetType)
                    .WithMany(p => p.FleetAssetSubtypes)
                    .HasForeignKey(d => d.FleetAssetTypeId)
                    .HasConstraintName("FK_FleetAssetSubtype_FleetAssetType");
            });

            modelBuilder.Entity<FleetAssetType>(entity =>
            {
                entity.ToTable("FleetAssetType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.FoxProCode).HasMaxLength(10);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<FleetConfiguration>(entity =>
            {
                entity.ToTable("FleetConfiguration");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AddedFrom).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.FleetAssetId).HasColumnName("FleetAssetID");

                entity.Property(e => e.FleetAssetId2).HasColumnName("FleetAssetID2");

                entity.Property(e => e.FleetAssetId3).HasColumnName("FleetAssetID3");

                entity.Property(e => e.FleetAssetId4).HasColumnName("FleetAssetID4");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.FleetAsset)
                    .WithMany(p => p.FleetConfigurationFleetAssets)
                    .HasForeignKey(d => d.FleetAssetId)
                    .HasConstraintName("FK_FleetConfiguration_FleetAsset");

                entity.HasOne(d => d.FleetAssetId2Navigation)
                    .WithMany(p => p.FleetConfigurationFleetAssetId2Navigations)
                    .HasForeignKey(d => d.FleetAssetId2)
                    .HasConstraintName("FK_FleetConfiguration_FleetAsset1");

                entity.HasOne(d => d.FleetAssetId3Navigation)
                    .WithMany(p => p.FleetConfigurationFleetAssetId3Navigations)
                    .HasForeignKey(d => d.FleetAssetId3)
                    .HasConstraintName("FK_FleetConfiguration_FleetAsset2");

                entity.HasOne(d => d.FleetAssetId4Navigation)
                    .WithMany(p => p.FleetConfigurationFleetAssetId4Navigations)
                    .HasForeignKey(d => d.FleetAssetId4)
                    .HasConstraintName("FK_FleetConfiguration_FleetAsset3");
            });

            modelBuilder.Entity<FleetRunningCost>(entity =>
            {
                entity.ToTable("FleetRunningCost");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostGroupId).HasColumnName("CostGroupID");

                entity.Property(e => e.FleetRunningCostTypeId).HasColumnName("FleetRunningCostTypeID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.Kilometers).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TrailerConfigurationId).HasColumnName("TrailerConfigurationID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FleetRunningCosts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetRunningCost_Company");

                entity.HasOne(d => d.CostGroup)
                    .WithMany(p => p.FleetRunningCosts)
                    .HasForeignKey(d => d.CostGroupId)
                    .HasConstraintName("FK_FleetRunningCost_CostGroup");

                entity.HasOne(d => d.FleetRunningCostType)
                    .WithMany(p => p.FleetRunningCosts)
                    .HasForeignKey(d => d.FleetRunningCostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FleetRunningCost_FleetRunningCostType");

                entity.HasOne(d => d.TrailerConfiguration)
                    .WithMany(p => p.FleetRunningCosts)
                    .HasForeignKey(d => d.TrailerConfigurationId)
                    .HasConstraintName("FK_FleetRunningCost_TrailerConfiguration");
            });

            modelBuilder.Entity<FleetRunningCostType>(entity =>
            {
                entity.ToTable("FleetRunningCostType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FoxProSyncDate>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.CompanyId });

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.LastSync).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.FoxProSyncDates)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FoxProSyncDates_Company");
            });

            modelBuilder.Entity<GeneralToll>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StateId)
                    .HasMaxLength(10)
                    .HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.GeneralTolls)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GeneralTolls_State");
            });

            modelBuilder.Entity<GenericGroup>(entity =>
            {
                entity.ToTable("GenericGroup");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedAt)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.GroupNumber)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GroupType)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UpdatedAt).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GenericGroups)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_GenericGroup_Company");
            });

            modelBuilder.Entity<GlobalAlert>(entity =>
            {
                entity.ToTable("GlobalAlert");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GlobalAlerts)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GlobalAlert_Company");
            });

            modelBuilder.Entity<Gpslog>(entity =>
            {
                entity.ToTable("GPSLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.AuthTokenNavigation)
                    .WithMany(p => p.Gpslogs)
                    .HasForeignKey(d => d.AuthToken)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GPSLog_AuthToken");
            });

            modelBuilder.Entity<GridStateColumn>(entity =>
            {
                entity.ToTable("GridStateColumn");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ColumnName).HasMaxLength(50);

                entity.Property(e => e.DataType).HasMaxLength(50);

                entity.Property(e => e.FilterType).HasMaxLength(50);

                entity.Property(e => e.ProfileId).HasColumnName("ProfileID");

                entity.Property(e => e.SelectedFilterOperation).HasMaxLength(100);

                entity.Property(e => e.SortOrder).HasMaxLength(10);

                entity.Property(e => e.Width).HasMaxLength(10);

                entity.HasOne(d => d.Profile)
                    .WithMany(p => p.GridStateColumns)
                    .HasForeignKey(d => d.ProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GridStateColumn_GridStateProfile");
            });

            modelBuilder.Entity<GridStateDefault>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GridId)
                    .HasMaxLength(50)
                    .HasColumnName("GridID");

                entity.Property(e => e.GridProfileId).HasColumnName("GridProfileID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.WebPanelUserId)
                    .HasMaxLength(50)
                    .HasColumnName("WebPanelUserID");

                entity.HasOne(d => d.GridProfile)
                    .WithMany(p => p.GridStateDefaults)
                    .HasForeignKey(d => d.GridProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GridStateDefaults_GridStateProfile");

                entity.HasOne(d => d.WebPanelUser)
                    .WithMany(p => p.GridStateDefaults)
                    .HasForeignKey(d => d.WebPanelUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GridStateDefaults_WebPanelUser");
            });

            modelBuilder.Entity<GridStateProfile>(entity =>
            {
                entity.ToTable("GridStateProfile");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DateFilterProfileId).HasColumnName("DateFilterProfileID");

                entity.Property(e => e.GridId)
                    .HasMaxLength(50)
                    .HasColumnName("GridID");

                entity.Property(e => e.ProfileName).HasMaxLength(50);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.GridStateProfiles)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_GridStateProfile_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GridStateProfiles)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_GridStateProfile_WebPanelUser");
            });

            modelBuilder.Entity<GridStateProfilePermission>(entity =>
            {
                entity.ToTable("GridStateProfilePermission");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GridCode).HasMaxLength(50);

                entity.Property(e => e.GridProfileId).HasColumnName("GridProfileID");

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.HasOne(d => d.GridProfile)
                    .WithMany(p => p.GridStateProfilePermissions)
                    .HasForeignKey(d => d.GridProfileId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GridStateProfilePermission_GridStateProfile");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.GridStateProfilePermissions)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GridStateProfilePermission_UserGroup");
            });

            modelBuilder.Entity<Gstcode>(entity =>
            {
                entity.ToTable("GSTCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Value).HasColumnType("decimal(10, 2)");
            });

            modelBuilder.Entity<HandwrittenPod>(entity =>
            {
                entity.ToTable("HandwrittenPOD");

                entity.HasIndex(e => new { e.JobId, e.Active }, "IX_HandwrittenPOD_JobID_Active");

                entity.HasIndex(e => e.JobLegId, "IX_HandwrittenPOD_JobLegId");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FileExtension)
                    .HasMaxLength(10)
                    .HasDefaultValueSql("(N'jpg')");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.HandwrittenPods)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HandwrittenPOD_Job");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.HandwrittenPods)
                    .HasForeignKey(d => d.JobLegId)
                    .HasConstraintName("FK_HandwrittenPOD_JobLeg");
            });

            modelBuilder.Entity<Hash>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Field })
                    .HasName("PK_HangFire_Hash");

                entity.ToTable("Hash", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Hash_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Field).HasMaxLength(100);
            });

            modelBuilder.Entity<ImportHistory>(entity =>
            {
                entity.ToTable("ImportHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ImportedFrom).HasMaxLength(50);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<ImportType>(entity =>
            {
                entity.ToTable("ImportType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ImportedContactsForUpdate>(entity =>
            {
                entity.ToTable("ImportedContactsForUpdate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContactId).HasColumnName("ContactID");

                entity.Property(e => e.Email).HasMaxLength(200);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Note).HasMaxLength(450);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Salutation).HasMaxLength(50);

                entity.Property(e => e.TypeId)
                    .HasMaxLength(10)
                    .HasColumnName("TypeID");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ImportedCustomersForUpdate>(entity =>
            {
                entity.ToTable("ImportedCustomersForUpdate");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Abn)
                    .HasMaxLength(50)
                    .HasColumnName("ABN");

                entity.Property(e => e.AccountCode).HasMaxLength(50);

                entity.Property(e => e.AccountName).HasMaxLength(50);

                entity.Property(e => e.AccountingSystemInstanceId).HasColumnName("AccountingSystemInstanceID");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Bpayreference)
                    .HasMaxLength(50)
                    .HasColumnName("BPAYReference");

                entity.Property(e => e.CanEditAdresses).HasDefaultValueSql("((0))");

                entity.Property(e => e.CanEditProducts).HasDefaultValueSql("((0))");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CustomerCodeNew).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerSendInvoicesTo).HasMaxLength(50);

                entity.Property(e => e.DefaultPricingScheduleTypeId).HasColumnName("DefaultPricingScheduleTypeID");

                entity.Property(e => e.ExportedToFoxPro).HasDefaultValueSql("((0))");

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.InvoiceAttachPod)
                    .HasColumnName("InvoiceAttachPOD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.InvoiceDeliveryMethodId)
                    .HasMaxLength(20)
                    .HasColumnName("InvoiceDeliveryMethodID");

                entity.Property(e => e.InvoiceFrequencyId)
                    .HasMaxLength(20)
                    .HasColumnName("InvoiceFrequencyID");

                entity.Property(e => e.InvoiceTemplateId).HasColumnName("InvoiceTemplateID");

                entity.Property(e => e.InvoicingGroupingId)
                    .HasMaxLength(20)
                    .HasColumnName("InvoicingGroupingID");

                entity.Property(e => e.IsAccount).HasDefaultValueSql("((0))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PaymentTermsEop)
                    .HasColumnName("PaymentTermsEOP")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PaymentTermsId)
                    .HasMaxLength(20)
                    .HasColumnName("PaymentTermsID");

                entity.Property(e => e.PostalLocationId).HasColumnName("PostalLocationID");

                entity.Property(e => e.RequireCustomerPodpaperwork)
                    .HasColumnName("RequireCustomerPODpaperwork")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequirePod)
                    .HasColumnName("RequirePOD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.RequirePodbeforeInvoicing)
                    .HasColumnName("RequirePODbeforeInvoicing")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ShowInvoice).HasDefaultValueSql("((0))");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(18, 0)");

                entity.Property(e => e.TradingName).HasMaxLength(250);

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.UseInvoiceExport).HasDefaultValueSql("((0))");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");
            });

            modelBuilder.Entity<ImportedJob>(entity =>
            {
                entity.ToTable("ImportedJob");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BookDate).HasColumnType("datetime");

                entity.Property(e => e.BookingContactId).HasColumnName("BookingContactID");

                entity.Property(e => e.BookingType).HasMaxLength(10);

                entity.Property(e => e.ChargeWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractBal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ContractBAL");

                entity.Property(e => e.ContractScheduleFinish).HasColumnType("datetime");

                entity.Property(e => e.ContractScheduleStart).HasColumnType("datetime");

                entity.Property(e => e.ContractWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Cubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CubicWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRequiredDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerRequiredEndTime).HasColumnType("datetime");

                entity.Property(e => e.DailyWeight).HasMaxLength(10);

                entity.Property(e => e.Delweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DELWeight");

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.ExportedToFoxpro).HasDefaultValueSql("((0))");

                entity.Property(e => e.FleetConfigurationId).HasColumnName("FleetConfigurationID");

                entity.Property(e => e.FoxProJobNumber).HasMaxLength(50);

                entity.Property(e => e.FreightBroughtToDepot).HasDefaultValueSql("('0')");

                entity.Property(e => e.FreightWillBePickedFromDepot).HasDefaultValueSql("('0')");

                entity.Property(e => e.FtpimportedPod)
                    .HasColumnName("FTPImportedPOD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Hours).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.HoursTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.JobCancelResponseId).HasColumnName("JobCancelResponseID");

                entity.Property(e => e.JobImportTypeId)
                    .HasMaxLength(3)
                    .HasColumnName("JobImportTypeID");

                entity.Property(e => e.JobKindId)
                    .HasMaxLength(5)
                    .HasColumnName("JobKindID");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobReference).HasMaxLength(300);

                entity.Property(e => e.JobServiceCodeId).HasColumnName("JobServiceCodeID");

                entity.Property(e => e.JobSourceId).HasColumnName("JobSourceID");

                entity.Property(e => e.JobStatusId)
                    .HasMaxLength(3)
                    .HasColumnName("JobStatusID");

                entity.Property(e => e.Kms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Otweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTWeight");

                entity.Property(e => e.Pallets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.PodappUserId).HasColumnName("PODAppUserID");

                entity.Property(e => e.PricingGst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PricingGST");

                entity.Property(e => e.PricingNet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricingStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("PricingStatusID");

                entity.Property(e => e.PricingTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProposedTimeSlotId).HasColumnName("ProposedTimeSlotID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadyFromCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadyFromDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.RecipientPhone).HasMaxLength(50);

                entity.Property(e => e.Refrence1).HasMaxLength(100);

                entity.Property(e => e.Refrence10).HasMaxLength(100);

                entity.Property(e => e.Refrence2).HasMaxLength(100);

                entity.Property(e => e.Refrence3).HasMaxLength(100);

                entity.Property(e => e.Refrence4).HasMaxLength(100);

                entity.Property(e => e.Refrence5).HasMaxLength(100);

                entity.Property(e => e.Refrence6).HasMaxLength(100);

                entity.Property(e => e.Refrence7).HasMaxLength(100);

                entity.Property(e => e.Refrence8).HasMaxLength(100);

                entity.Property(e => e.Refrence9).HasMaxLength(100);

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.Space).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrackingCode).HasMaxLength(50);

                entity.Property(e => e.TripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("TripStatusID");

                entity.Property(e => e.TripWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'admin')");

                entity.Property(e => e.Waiting).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightType).HasMaxLength(10);
            });

            modelBuilder.Entity<ImportedJobPricing>(entity =>
            {
                entity.ToTable("ImportedJobPricing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PricingItemId).HasColumnName("PricingItemID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength();

                entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UnitRate)
                    .HasColumnType("decimal(18, 4)")
                    .HasDefaultValueSql("((0.000))");
            });

            modelBuilder.Entity<ImportedJobProduct>(entity =>
            {
                entity.ToTable("ImportedJobProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.ChargeWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CubicWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField01).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField02).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField03).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField04).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField05).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Delweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DELWeight");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FoxProJobProductNumber).HasMaxLength(50);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hooks).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Otweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTWeight");

                entity.Property(e => e.Pallet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PalletTypeId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PalletTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.ShippingUnit).HasMaxLength(100);

                entity.Property(e => e.Space).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Temp).HasMaxLength(100);

                entity.Property(e => e.Ties).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<InterfaceType>(entity =>
            {
                entity.ToTable("InterfaceType");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<InterfaceVersion>(entity =>
            {
                entity.ToTable("InterfaceVersion");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.AccountingSystemId)
                    .HasMaxLength(10)
                    .HasColumnName("AccountingSystemID");

                entity.Property(e => e.InterfaceTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("InterfaceTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.AccountingSystem)
                    .WithMany(p => p.InterfaceVersions)
                    .HasForeignKey(d => d.AccountingSystemId)
                    .HasConstraintName("FK_InterfaceVersion_AccountingSystem");

                entity.HasOne(d => d.InterfaceType)
                    .WithMany(p => p.InterfaceVersions)
                    .HasForeignKey(d => d.InterfaceTypeId)
                    .HasConstraintName("FK_InterfaceVersion_InterfaceType");
            });

            modelBuilder.Entity<InternalTrackStatus>(entity =>
            {
                entity.ToTable("InternalTrackStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(150);
            });

            modelBuilder.Entity<Invoice>(entity =>
            {
                entity.ToTable("Invoice");

                entity.HasIndex(e => new { e.CustomerId, e.CompanyId, e.Date }, "_dta_index_Invoice_22_101627455__K16_K19_K2_1_3_4_5_6_7_8_9_10_11_12_13_14_15_17_18_20")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.CompanyId, e.Date }, "_dta_index_Invoice_22_101627455__K19_K2")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.CompanyId, e.Date }, "_dta_index_Invoice_22_101627455__K19_K2_1_3_4_5_6_7_8_9_10_11_12_13_14_15_16_17_18_20")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.BatchNumber).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Credit).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Debit).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.EntDate).HasColumnType("datetime");

                entity.Property(e => e.Gross).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Gst).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.GstRate).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.ImportedBy).HasMaxLength(50);

                entity.Property(e => e.Nett).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.Outstand).HasColumnType("decimal(16, 2)");

                entity.Property(e => e.PayDate).HasColumnType("datetime");

                entity.Property(e => e.StatusId)
                    .HasMaxLength(10)
                    .HasColumnName("StatusID");

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Invoice_Customer");

                entity.HasOne(d => d.ImportedByNavigation)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.ImportedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Invoice_WebPanelUser");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Invoices)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK_Invoice_InvoiceStatus");
            });

            modelBuilder.Entity<InvoiceBatch>(entity =>
            {
                entity.ToTable("InvoiceBatch");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.InvoiceBatches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceBatch_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.InvoiceBatches)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_InvoiceBatch_WebPanelUser");
            });

            modelBuilder.Entity<InvoiceDeliveryMethod>(entity =>
            {
                entity.ToTable("InvoiceDeliveryMethod");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoiceNumberTemp>(entity =>
            {
                entity.ToTable("InvoiceNumberTemp");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");
            });

            modelBuilder.Entity<InvoiceSalesJournalExport>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.IpAddress).HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserName).HasMaxLength(100);
            });

            modelBuilder.Entity<InvoiceSalesJournalExportedInvoice>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceSalesJournalExportId).HasColumnName("InvoiceSalesJournalExportID");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.HasOne(d => d.InvoiceSalesJournalExport)
                    .WithMany(p => p.InvoiceSalesJournalExportedInvoices)
                    .HasForeignKey(d => d.InvoiceSalesJournalExportId)
                    .HasConstraintName("FK_InvoiceSalesJournalExportID");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.InvoiceSalesJournalExportedInvoices)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .HasConstraintName("FK_PanelInvoiceID");
            });

            modelBuilder.Entity<InvoiceStatus>(entity =>
            {
                entity.ToTable("InvoiceStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoicingFrequency>(entity =>
            {
                entity.ToTable("InvoicingFrequency");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoicingGrouping>(entity =>
            {
                entity.ToTable("InvoicingGrouping");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<InvoicingUitext>(entity =>
            {
                entity.ToTable("InvoicingUIText");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingSystemId)
                    .HasMaxLength(10)
                    .HasColumnName("AccountingSystemID");

                entity.Property(e => e.InterfaceTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("InterfaceTypeID");

                entity.Property(e => e.Text).HasMaxLength(200);

                entity.Property(e => e.Uielement)
                    .HasMaxLength(50)
                    .HasColumnName("UIElement");

                entity.HasOne(d => d.AccountingSystem)
                    .WithMany(p => p.InvoicingUitexts)
                    .HasForeignKey(d => d.AccountingSystemId)
                    .HasConstraintName("FK_InvoicingUIText_AccountingSystem");

                entity.HasOne(d => d.InterfaceType)
                    .WithMany(p => p.InvoicingUitexts)
                    .HasForeignKey(d => d.InterfaceTypeId)
                    .HasConstraintName("FK_InvoicingUIText_InterfaceType");
            });

            modelBuilder.Entity<Job>(entity =>
            {
                entity.ToTable("Job");

                entity.HasIndex(e => new { e.CompanyId, e.JobStatusId, e.TimeStamp }, "_dta_index_Job_22_855010127__K19_K5_K8_1_2_3_4_6_7_9_10_11_12_13_14_15_16_17_18_20_21_22_23_24_25_26_27_28_29_30_31_32_33_34_")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.JobStatusId, e.CompanyId }, "_dta_index_Job_22_855010127__K5_K19")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Id, e.PricingStatusId, e.JobStatusId, e.JobServiceCodeId, e.CustomerId, e.ProductOwner, e.BookingContactId, e.SenderId, e.RecipientId, e.DepotId }, "_dta_index_Job_5_426588708__K1_K43_K5_K24_K7_K65_K81_K11_K12_K80_15_16_17_19_32_35_46_47_48_49_51_52_53_54_55_58_63_64_74_75_");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.BookDate).HasColumnType("datetime");

                entity.Property(e => e.BookingContactId).HasColumnName("BookingContactID");

                entity.Property(e => e.BookingType).HasMaxLength(10);

                entity.Property(e => e.ChargeWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ContractBal)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("ContractBAL");

                entity.Property(e => e.ContractScheduleFinish).HasColumnType("datetime");

                entity.Property(e => e.ContractScheduleStart).HasColumnType("datetime");

                entity.Property(e => e.ContractWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostingTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CreatedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Cubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CubicWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerRequiredDate).HasColumnType("datetime");

                entity.Property(e => e.CustomerRequiredEndTime).HasColumnType("datetime");

                entity.Property(e => e.DailyWeight).HasMaxLength(10);

                entity.Property(e => e.Delweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DELWeight");

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.ExpenseTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ExportedToFoxpro).HasDefaultValueSql("((0))");

                entity.Property(e => e.FleetConfigurationId).HasColumnName("FleetConfigurationID");

                entity.Property(e => e.FoxProJobNumber).HasMaxLength(50);

                entity.Property(e => e.FreightBroughtToDepot).HasDefaultValueSql("('0')");

                entity.Property(e => e.FreightWillBePickedFromDepot).HasDefaultValueSql("('0')");

                entity.Property(e => e.FtpimportedPod)
                    .HasColumnName("FTPImportedPOD")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.Hours).HasColumnType("decimal(4, 2)");

                entity.Property(e => e.HoursTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.JobCancelResponseId).HasColumnName("JobCancelResponseID");

                entity.Property(e => e.JobImportTypeId)
                    .HasMaxLength(3)
                    .HasColumnName("JobImportTypeID");

                entity.Property(e => e.JobKindId)
                    .HasMaxLength(5)
                    .HasColumnName("JobKindID");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobReference).HasMaxLength(2000);

                entity.Property(e => e.JobServiceCodeId).HasColumnName("JobServiceCodeID");

                entity.Property(e => e.JobSourceId).HasColumnName("JobSourceID");

                entity.Property(e => e.JobStatusId)
                    .HasMaxLength(3)
                    .HasColumnName("JobStatusID");

                entity.Property(e => e.Kms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Otweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTWeight");

                entity.Property(e => e.Pallets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.PodappUserId).HasColumnName("PODAppUserID");

                entity.Property(e => e.PricingGst)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("PricingGST");

                entity.Property(e => e.PricingNet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricingStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("PricingStatusID");

                entity.Property(e => e.PricingTotal).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ProposedTimeSlotId).HasColumnName("ProposedTimeSlotID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadyFromCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadyFromDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.RecipientPhone).HasMaxLength(50);

                entity.Property(e => e.Refrence1).HasMaxLength(200);

                entity.Property(e => e.Refrence10).HasMaxLength(200);

                entity.Property(e => e.Refrence2).HasMaxLength(200);

                entity.Property(e => e.Refrence3).HasMaxLength(200);

                entity.Property(e => e.Refrence4).HasMaxLength(200);

                entity.Property(e => e.Refrence5).HasMaxLength(200);

                entity.Property(e => e.Refrence6).HasMaxLength(200);

                entity.Property(e => e.Refrence7).HasMaxLength(200);

                entity.Property(e => e.Refrence8).HasMaxLength(200);

                entity.Property(e => e.Refrence9).HasMaxLength(200);

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.Space).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.TrackingCode).HasMaxLength(50);

                entity.Property(e => e.TripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("TripStatusID");

                entity.Property(e => e.TripWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID")
                    .HasDefaultValueSql("(N'admin')");

                entity.Property(e => e.Waiting).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WeightType).HasMaxLength(10);

                entity.HasOne(d => d.BookingContact)
                    .WithMany(p => p.JobBookingContacts)
                    .HasForeignKey(d => d.BookingContactId)
                    .HasConstraintName("FK_Job_Contact");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Job_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.JobCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_Customer");

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.JobDepots)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_Job_Location2");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.JobGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_Job_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.JobGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_Job_Group2");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.InvoiceId)
                    .HasConstraintName("FK_Job_Invoice");

                entity.HasOne(d => d.JobCancelResponse)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobCancelResponseId)
                    .HasConstraintName("FK_Job_JobCancelResponse");

                entity.HasOne(d => d.JobImportType)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobImportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_JobImportType");

                entity.HasOne(d => d.JobKind)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobKindId)
                    .HasConstraintName("FK_Job_JobKind");

                entity.HasOne(d => d.JobServiceCode)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobServiceCodeId)
                    .HasConstraintName("FK_Job_ServiceCode");

                entity.HasOne(d => d.JobSource)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobSourceId)
                    .HasConstraintName("FK_Job_JobSource");

                entity.HasOne(d => d.JobStatus)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.JobStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_JobStatus");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.JobModifiedByNavigations)
                    .HasForeignKey(d => d.ModifiedBy)
                    .HasConstraintName("FK_Job_WebPanelUser1");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .HasConstraintName("FK_Job_PanelInvoice");

                entity.HasOne(d => d.PodappUser)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.PodappUserId)
                    .HasConstraintName("FK_Job_User");

                entity.HasOne(d => d.PricingStatus)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.PricingStatusId)
                    .HasConstraintName("FK_Job_PricingStatus");

                entity.HasOne(d => d.ProductOwnerNavigation)
                    .WithMany(p => p.JobProductOwnerNavigations)
                    .HasForeignKey(d => d.ProductOwner)
                    .HasConstraintName("FK_Job_Customer1");

                entity.HasOne(d => d.ProposedTimeSlot)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.ProposedTimeSlotId)
                    .HasConstraintName("FK_Job_TimeSlot");

                entity.HasOne(d => d.ReceiverContactNavigation)
                    .WithMany(p => p.JobReceiverContactNavigations)
                    .HasForeignKey(d => d.ReceiverContact)
                    .HasConstraintName("FK_Job_ReceiverContact");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.JobRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .HasConstraintName("FK_Job_Location1");

                entity.HasOne(d => d.SenderContactNavigation)
                    .WithMany(p => p.JobSenderContactNavigations)
                    .HasForeignKey(d => d.SenderContact)
                    .HasConstraintName("FK_Job_SenderContact");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.JobSenders)
                    .HasForeignKey(d => d.SenderId)
                    .HasConstraintName("FK_Job_Location");

                entity.HasOne(d => d.TripStatus)
                    .WithMany(p => p.Jobs)
                    .HasForeignKey(d => d.TripStatusId)
                    .HasConstraintName("FK_Job_JobTripStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobUsers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Job_WebPanelUser");
            });

            modelBuilder.Entity<Job1>(entity =>
            {
                entity.ToTable("Job", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Job_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => e.StateName, "IX_HangFire_Job_StateName")
                    .HasFilter("([StateName] IS NOT NULL)");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");

                entity.Property(e => e.StateName).HasMaxLength(20);
            });

            modelBuilder.Entity<JobCancelReason>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobCancelReasons)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_JobCancelReasons_Company");
            });

            modelBuilder.Entity<JobCancelResponse>(entity =>
            {
                entity.ToTable("JobCancelResponse");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobCancelReasonId).HasColumnName("JobCancelReasonID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Notes).HasMaxLength(200);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.JobCancelReason)
                    .WithMany(p => p.JobCancelResponses)
                    .HasForeignKey(d => d.JobCancelReasonId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobCancelResponse_JobCancelReasons");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobCancelResponses)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobCancelResponse_WebPanelUser");
            });

            modelBuilder.Entity<JobCode>(entity =>
            {
                entity.ToTable("JobCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(16);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobCodes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobCode_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.JobCodes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobCode_WebPanelUser");
            });

            modelBuilder.Entity<JobDocument>(entity =>
            {
                entity.ToTable("JobDocument");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Extension).HasMaxLength(10);

                entity.Property(e => e.JobDocumentTypeId).HasColumnName("JobDocumentTypeID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.MimeType).HasMaxLength(100);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UploadedBy).HasMaxLength(50);

                entity.HasOne(d => d.JobDocumentType)
                    .WithMany(p => p.JobDocuments)
                    .HasForeignKey(d => d.JobDocumentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobDocument_JobDocumentType");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobDocuments)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobDocument_Job");

                entity.HasOne(d => d.UploadedByNavigation)
                    .WithMany(p => p.JobDocuments)
                    .HasForeignKey(d => d.UploadedBy)
                    .HasConstraintName("FK_JobDocument_WebPanelUser");
            });

            modelBuilder.Entity<JobDocumentType>(entity =>
            {
                entity.ToTable("JobDocumentType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobDocumentTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobDocumentType_Company");
            });

            modelBuilder.Entity<JobHistory>(entity =>
            {
                entity.ToTable("JobHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobStatusId)
                    .HasMaxLength(3)
                    .HasColumnName("JobStatusID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobHistories)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobHistory_Job");

                entity.HasOne(d => d.JobStatus)
                    .WithMany(p => p.JobHistories)
                    .HasForeignKey(d => d.JobStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobHistory_JobStatus");
            });

            modelBuilder.Entity<JobImportMatch>(entity =>
            {
                entity.ToTable("JobImportMatch");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<JobImportMethod>(entity =>
            {
                entity.ToTable("JobImportMethod");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<JobImportMode>(entity =>
            {
                entity.ToTable("JobImportMode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.MatchId)
                    .HasMaxLength(10)
                    .HasColumnName("MatchID");

                entity.Property(e => e.MethodId)
                    .HasMaxLength(10)
                    .HasColumnName("MethodID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RejectMethodId)
                    .HasMaxLength(10)
                    .HasColumnName("RejectMethodID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobImportModes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobImportMode_Company");

                entity.HasOne(d => d.Match)
                    .WithMany(p => p.JobImportModes)
                    .HasForeignKey(d => d.MatchId)
                    .HasConstraintName("FK_JobImportMode_JobImportMatch");

                entity.HasOne(d => d.Method)
                    .WithMany(p => p.JobImportModes)
                    .HasForeignKey(d => d.MethodId)
                    .HasConstraintName("FK_JobImportMode_JobImportMethod");

                entity.HasOne(d => d.RejectMethod)
                    .WithMany(p => p.JobImportModes)
                    .HasForeignKey(d => d.RejectMethodId)
                    .HasConstraintName("FK_JobImportMode_JobImportRejectMethod");
            });

            modelBuilder.Entity<JobImportRejectMethod>(entity =>
            {
                entity.ToTable("JobImportRejectMethod");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<JobImportType>(entity =>
            {
                entity.ToTable("JobImportType");

                entity.Property(e => e.Id)
                    .HasMaxLength(3)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JobKind>(entity =>
            {
                entity.ToTable("JobKind");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JobLeg>(entity =>
            {
                entity.ToTable("JobLeg");

                entity.HasIndex(e => e.JobId, "IX_JobLeg_JobId");

                entity.HasIndex(e => new { e.JobId, e.Active }, "IX_JobLeg_JobId_Active");

                entity.HasIndex(e => new { e.Active, e.Id, e.ManifestId, e.FleetConfigurationId, e.CostingStatusId, e.TripStatusId, e.LegStatusId, e.ServiceCodeId, e.JobLegTypeId, e.JobId, e.SenderId, e.RecepientId, e.DepotId, e.DriverId }, "_dta_index_JobLeg_5_1255011552__K48_K1_K57_K70_K76_K12_K74_K58_K15_K50_K22_K23_K73_K20_2_10_33_34_35_36_45_53_54_59_78_79_80_");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ArrivedReceiverTimestamp).HasColumnType("datetime");

                entity.Property(e => e.ArrivedSenderTimestamp).HasColumnType("datetime");

                entity.Property(e => e.ConsignmentNumber).HasMaxLength(50);

                entity.Property(e => e.ConsignmentReference).HasMaxLength(50);

                entity.Property(e => e.CostingStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("CostingStatusID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.CustomerReference).HasMaxLength(50);

                entity.Property(e => e.DepartedReceiverTimestamp).HasColumnType("datetime");

                entity.Property(e => e.DepartedSenderTimestamp).HasColumnType("datetime");

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.Doors).HasMaxLength(50);

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.DueTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Eta)
                    .HasColumnType("datetime")
                    .HasColumnName("ETA");

                entity.Property(e => e.FleetConfigurationId).HasColumnName("FleetConfigurationID");

                entity.Property(e => e.FoxProJobLegNumber).HasMaxLength(50);

                entity.Property(e => e.HiTransConsignmentId).HasMaxLength(50);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobKindId)
                    .HasMaxLength(5)
                    .HasColumnName("JobKindID");

                entity.Property(e => e.JobLegTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("JobLegTypeID");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobReference).HasMaxLength(300);

                entity.Property(e => e.JobTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("JobTypeID");

                entity.Property(e => e.LegCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegNettCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("LegStatusID");

                entity.Property(e => e.LegTotalHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegTotalKilometers).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegTotalQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.MasterNumber).HasMaxLength(50);

                entity.Property(e => e.OrderNumber).HasDefaultValueSql("((-1))");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.ParentLegId).HasColumnName("ParentLegID");

                entity.Property(e => e.ParentLocationId).HasColumnName("ParentLocationID");

                entity.Property(e => e.PodexceptionId)
                    .HasMaxLength(5)
                    .HasColumnName("PODExceptionID");

                entity.Property(e => e.PodexceptionNote).HasColumnName("PODExceptionNote");

                entity.Property(e => e.PodstatusId)
                    .HasMaxLength(5)
                    .HasColumnName("PODStatusID");

                entity.Property(e => e.Price).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Product).HasMaxLength(200);

                entity.Property(e => e.ReceiverAppNote).HasMaxLength(200);

                entity.Property(e => e.RecepientId).HasColumnName("RecepientID");

                entity.Property(e => e.RecepientPhone).HasMaxLength(50);

                entity.Property(e => e.ReleaseNumber).HasMaxLength(50);

                entity.Property(e => e.SenderAppNote).HasMaxLength(200);

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.SenderSignedBy).HasMaxLength(50);

                entity.Property(e => e.ServiceCode).HasMaxLength(50);

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.Property(e => e.SignedBy).HasMaxLength(50);

                entity.Property(e => e.SmartFreightConsignmentId).HasMaxLength(50);

                entity.Property(e => e.TimeSlotId).HasColumnName("TimeSlotID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampAcknowledged).HasColumnType("datetime");

                entity.Property(e => e.TrackingCode).HasMaxLength(50);

                entity.Property(e => e.Trailer1Id).HasColumnName("Trailer1ID");

                entity.Property(e => e.Trailer2Id).HasColumnName("Trailer2ID");

                entity.Property(e => e.TripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("TripStatusID");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.WorkflowId)
                    .HasMaxLength(5)
                    .HasColumnName("WorkflowID");

                entity.Property(e => e.WorkflowSubId)
                    .HasMaxLength(5)
                    .HasColumnName("WorkflowSubID");

                entity.HasOne(d => d.CostingStatus)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.CostingStatusId)
                    .HasConstraintName("FK_JobLeg_CostingStatus");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLeg_Customer");

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.JobLegDepots)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_JobLeg_Location2");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_JobLeg_User");

                entity.HasOne(d => d.FleetConfiguration)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.FleetConfigurationId)
                    .HasConstraintName("FK_JobLeg_FleetConfiguration");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_JobLeg_Job");

                entity.HasOne(d => d.JobKind)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.JobKindId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLeg_JobKind");

                entity.HasOne(d => d.JobLegType)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.JobLegTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLeg_JobLegType");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.JobTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLeg_JobType");

                entity.HasOne(d => d.LegStatus)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.LegStatusId)
                    .HasConstraintName("FK_LegStatusID");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_JobLeg_Manifest");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .HasConstraintName("FK_JobLeg_SubcontractorInvoice");

                entity.HasOne(d => d.Podexception)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.PodexceptionId)
                    .HasConstraintName("FK_Job_PODException");

                entity.HasOne(d => d.Podstatus)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.PodstatusId)
                    .HasConstraintName("FK_Job_PODStatus");

                entity.HasOne(d => d.Recepient)
                    .WithMany(p => p.JobLegRecepients)
                    .HasForeignKey(d => d.RecepientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLeg_Location1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.JobLegSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLeg_Location");

                entity.HasOne(d => d.ServiceCodeNavigation)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .HasConstraintName("FK_JobLeg_ServiceCode");

                entity.HasOne(d => d.TimeSlot)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.TimeSlotId)
                    .HasConstraintName("FK_JobLeg_TimeSlot");

                entity.HasOne(d => d.Trailer1)
                    .WithMany(p => p.JobLegTrailer1s)
                    .HasForeignKey(d => d.Trailer1Id)
                    .HasConstraintName("FK_JobLeg_Vehicle1");

                entity.HasOne(d => d.Trailer2)
                    .WithMany(p => p.JobLegTrailer2s)
                    .HasForeignKey(d => d.Trailer2Id)
                    .HasConstraintName("FK_JobLeg_Vehicle2");

                entity.HasOne(d => d.TripStatus)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.TripStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Job_TripStatus");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.JobLegVehicles)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_JobLeg_Vehicle");

                entity.HasOne(d => d.Workflow)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.WorkflowId)
                    .HasConstraintName("FK_JobLeg_WorkflowKind");

                entity.HasOne(d => d.WorkflowSub)
                    .WithMany(p => p.JobLegs)
                    .HasForeignKey(d => d.WorkflowSubId)
                    .HasConstraintName("FK_JobLeg_WorkflowSubKind");
            });

            modelBuilder.Entity<JobLegActivity>(entity =>
            {
                entity.ToTable("JobLegActivity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActivityId).HasColumnName("ActivityID");

                entity.Property(e => e.CustomActivityId).HasColumnName("CustomActivityID");

                entity.Property(e => e.CustomActivityValue).HasMaxLength(200);

                entity.Property(e => e.DeviceTimestamp).HasColumnType("datetime");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.Activity)
                    .WithMany(p => p.JobLegActivities)
                    .HasForeignKey(d => d.ActivityId)
                    .HasConstraintName("FK_JobLegActivity_Activity");

                entity.HasOne(d => d.CustomActivity)
                    .WithMany(p => p.JobLegActivities)
                    .HasForeignKey(d => d.CustomActivityId)
                    .HasConstraintName("FK_JobLegActivity_CustomActivity");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegActivities)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegActivity_JobLeg");
            });

            modelBuilder.Entity<JobLegCosting>(entity =>
            {
                entity.ToTable("JobLegCosting");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.CostItemId).HasColumnName("CostItemID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength();

                entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UnitRate).HasColumnType("decimal(10, 2)");

                entity.HasOne(d => d.CostItem)
                    .WithMany(p => p.JobLegCostings)
                    .HasForeignKey(d => d.CostItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegCosting_Pricing");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegCostings)
                    .HasForeignKey(d => d.JobLegId)
                    .HasConstraintName("FK_JobLegCosting_JobLeg");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.JobLegCostings)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_JobLegCosting_Manifest");
            });

            modelBuilder.Entity<JobLegCostingStatusHistory>(entity =>
            {
                entity.ToTable("JobLegCostingStatusHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CostingStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("CostingStatusID");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.CostingStatus)
                    .WithMany(p => p.JobLegCostingStatusHistories)
                    .HasForeignKey(d => d.CostingStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CostingStatusHistory_CostingStatus");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegCostingStatusHistories)
                    .HasForeignKey(d => d.JobLegId)
                    .HasConstraintName("FK_CostingStatusHistory_JobLeg");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.JobLegCostingStatusHistories)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_JobLegCostingStatusHistory_Manifest");
            });

            modelBuilder.Entity<JobLegCustomActivity>(entity =>
            {
                entity.ToTable("JobLegCustomActivity");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomActivityId).HasColumnName("CustomActivityID");

                entity.Property(e => e.DeviceTimestamp).HasColumnType("datetime");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.HasOne(d => d.CustomActivity)
                    .WithMany(p => p.JobLegCustomActivities)
                    .HasForeignKey(d => d.CustomActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegCustomActivity_CustomActivity");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegCustomActivities)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegCustomActivity_JobLeg");
            });

            modelBuilder.Entity<JobLegCustomActivityHistory>(entity =>
            {
                entity.ToTable("JobLegCustomActivityHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobLegCustomActivityId).HasColumnName("JobLegCustomActivityID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.JobLegCustomActivity)
                    .WithMany(p => p.JobLegCustomActivityHistories)
                    .HasForeignKey(d => d.JobLegCustomActivityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegCustomActivityHistory_JobLegCustomActivity");
            });

            modelBuilder.Entity<JobLegHistory>(entity =>
            {
                entity.ToTable("JobLegHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceTimestamp).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("TripStatusID");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegHistories)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegHistory_JobLeg");

                entity.HasOne(d => d.TripStatus)
                    .WithMany(p => p.JobLegHistories)
                    .HasForeignKey(d => d.TripStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegHistory_TripStatus");
            });

            modelBuilder.Entity<JobLegPallet>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BookedQuantity).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.DeliveredQuantity).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.MovementTypeId).HasColumnName("MovementTypeID");

                entity.Property(e => e.PalletTypeId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PalletTypeID")
                    .IsFixedLength();

                entity.Property(e => e.PickedQuantity).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.WebPanelUserId)
                    .HasMaxLength(50)
                    .HasColumnName("WebPanelUserID");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.JobLegPallets)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("FK_JobLegPallets_User");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegPallets)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegPallets_JobLeg");

                entity.HasOne(d => d.MovementType)
                    .WithMany(p => p.JobLegPallets)
                    .HasForeignKey(d => d.MovementTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegPallets_PalletMovementType");

                entity.HasOne(d => d.PalletType)
                    .WithMany(p => p.JobLegPallets)
                    .HasForeignKey(d => d.PalletTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegPallets_PalletTypes");

                entity.HasOne(d => d.WebPanelUser)
                    .WithMany(p => p.JobLegPallets)
                    .HasForeignKey(d => d.WebPanelUserId)
                    .HasConstraintName("FK_JobLegPallets_WebPanelUser");
            });

            modelBuilder.Entity<JobLegProduct>(entity =>
            {
                entity.ToTable("JobLegProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField01).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField02).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField03).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField04).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField05).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hooks).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Pallet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PalletTypeId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PalletTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.ShippingUnit).HasMaxLength(100);

                entity.Property(e => e.Space).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Temp).HasMaxLength(100);

                entity.Property(e => e.Ties).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TimestampScanLoad).HasColumnType("datetime");

                entity.Property(e => e.TimestampScanOff).HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegProducts)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegProduct_JobLeg");

                entity.HasOne(d => d.PalletType)
                    .WithMany(p => p.JobLegProducts)
                    .HasForeignKey(d => d.PalletTypeId)
                    .HasConstraintName("FK_JobLegProduct_PalletTypes");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.JobLegProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobLegProduct_Product");
            });

            modelBuilder.Entity<JobLegStatusHistory>(entity =>
            {
                entity.ToTable("JobLegStatusHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.LegStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("LegStatusID");

                entity.Property(e => e.StatusName).HasMaxLength(50);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.JobLegStatusHistories)
                    .HasForeignKey(d => d.JobLegId)
                    .HasConstraintName("FK__JobLegSta__JobLe__076201D4");

                entity.HasOne(d => d.LegStatus)
                    .WithMany(p => p.JobLegStatusHistories)
                    .HasForeignKey(d => d.LegStatusId)
                    .HasConstraintName("FK__JobLegSta__LegSt__0856260D");
            });

            modelBuilder.Entity<JobLegType>(entity =>
            {
                entity.ToTable("JobLegType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JobParameter>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Name })
                    .HasName("PK_HangFire_JobParameter");

                entity.ToTable("JobParameter", "HangFire");

                entity.Property(e => e.Name).HasMaxLength(40);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobParameters)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_JobParameter_Job");
            });

            modelBuilder.Entity<JobPrice>(entity =>
            {
                entity.ToTable("JobPrice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FoxProJobNumber).HasMaxLength(50);

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Gst).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Nett).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobPrices)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_JobPrice_Job");
            });

            modelBuilder.Entity<JobPricing>(entity =>
            {
                entity.ToTable("JobPricing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasMaxLength(200);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobProductId).HasColumnName("JobProductID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PricingItemId).HasColumnName("PricingItemID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.Status)
                    .HasMaxLength(1)
                    .HasDefaultValueSql("('M')")
                    .IsFixedLength();

                entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.UnitRate).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.JobPricings)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .HasConstraintName("FK_JobPricing_PricingChargeUnit");

                entity.HasOne(d => d.Gstcode)
                    .WithMany(p => p.JobPricings)
                    .HasForeignKey(d => d.GstcodeId)
                    .HasConstraintName("FK_JobPricing_GSTCode");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobPricings)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPricing_Job");

                entity.HasOne(d => d.JobProduct)
                    .WithMany(p => p.JobPricings)
                    .HasForeignKey(d => d.JobProductId)
                    .HasConstraintName("FK_JobPricing_JobProduct");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.JobPricings)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobPricing_WebPanelUser");

                entity.HasOne(d => d.PricingItem)
                    .WithMany(p => p.JobPricings)
                    .HasForeignKey(d => d.PricingItemId)
                    .HasConstraintName("FK_JobPricing_Pricing");
            });

            modelBuilder.Entity<JobPricingHistory>(entity =>
            {
                entity.ToTable("JobPricingHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChangeDescription).HasMaxLength(100);

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobPricing).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<JobProduct>(entity =>
            {
                entity.ToTable("JobProduct");

                entity.HasIndex(e => e.JobId, "IX_JobProduct_JobId");

                entity.HasIndex(e => new { e.JobId, e.Id }, "_dta_index_JobProduct_5_2087014516__K2_K1_5_8_9_10_11_12_14_26_27");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Barcode).HasMaxLength(50);

                entity.Property(e => e.ChargeWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Cubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField01).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField02).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField03).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField04).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomField05).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Delweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DELWeight");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.FoxProJobProductNumber).HasMaxLength(50);

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Hooks).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Otweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTWeight");

                entity.Property(e => e.Pallet).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PalletTypeId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("PalletTypeID")
                    .IsFixedLength();

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.ShippingUnit).HasMaxLength(100);

                entity.Property(e => e.Space).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Temp).HasMaxLength(100);

                entity.Property(e => e.Ties).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobProducts)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobProduct_Job");

                entity.HasOne(d => d.PalletType)
                    .WithMany(p => p.JobProducts)
                    .HasForeignKey(d => d.PalletTypeId)
                    .HasConstraintName("FK_JobProduct_PalletTypes");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.JobProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobProduct_Product");
            });

            modelBuilder.Entity<JobProductHistory>(entity =>
            {
                entity.ToTable("JobProductHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ChangeDescription).HasMaxLength(100);

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobProduct).HasMaxLength(100);

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<JobQueue>(entity =>
            {
                entity.HasKey(e => new { e.Queue, e.Id })
                    .HasName("PK_HangFire_JobQueue");

                entity.ToTable("JobQueue", "HangFire");

                entity.Property(e => e.Queue).HasMaxLength(50);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.FetchedAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<JobSenderRecipientDefault>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DefaultCustomerId).HasColumnName("DefaultCustomerID");

                entity.Property(e => e.DefaultDistance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.DefaultHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GoogleDistance).HasColumnType("decimal(18, 3)");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.JobSenderRecipientDefaults)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSenderRecipientDefaults_Company");

                entity.HasOne(d => d.DefaultCustomer)
                    .WithMany(p => p.JobSenderRecipientDefaults)
                    .HasForeignKey(d => d.DefaultCustomerId)
                    .HasConstraintName("FK_JobSenderRecipientDefaults_Customer");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.JobSenderRecipientDefaultRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSenderRecipientDefaults_Location1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.JobSenderRecipientDefaultSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobSenderRecipientDefaults_Location");
            });

            modelBuilder.Entity<JobSource>(entity =>
            {
                entity.ToTable("JobSource");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JobStatus>(entity =>
            {
                entity.ToTable("JobStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(3)
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JobTripStatus>(entity =>
            {
                entity.ToTable("JobTripStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<JobTripStatusHistory>(entity =>
            {
                entity.ToTable("JobTripStatusHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ExternalJobStatusImportId).HasColumnName("ExternalJobStatusImportID");

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobTripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("JobTripStatusID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeStampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimeStampUTC");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.ExternalJobStatusImport)
                    .WithMany(p => p.JobTripStatusHistories)
                    .HasForeignKey(d => d.ExternalJobStatusImportId)
                    .HasConstraintName("FK_ExternalJobStatusImportID");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.JobTripStatusHistories)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobTripStatusHistory_Job");

                entity.HasOne(d => d.JobTripStatus)
                    .WithMany(p => p.JobTripStatusHistories)
                    .HasForeignKey(d => d.JobTripStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_JobTripStatusHistory_JobTripStatus");
            });

            modelBuilder.Entity<JobType>(entity =>
            {
                entity.ToTable("JobType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<LegCreationMethod>(entity =>
            {
                entity.ToTable("LegCreationMethod");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.LegCreationMethodName).HasMaxLength(50);
            });

            modelBuilder.Entity<LegStatus>(entity =>
            {
                entity.ToTable("LegStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<List>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Id })
                    .HasName("PK_HangFire_List");

                entity.ToTable("List", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_List_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("Location");

                entity.HasIndex(e => e.AddressFull, "IX_AddressFull_ASC");

                entity.HasIndex(e => e.AddressFull, "IX_AddressFull_DESC");

                entity.HasIndex(e => new { e.LocationTypeId, e.CompanyId }, "_dta_index_Location_22_242151958__K12_K10")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.LocationTypeId, e.CompanyId, e.Name }, "_dta_index_Location_22_242151958__K12_K10_K2_1_3_4_5_6_7_8_9_11_13_14_15_16_17_18_19_20_21_22_23")
                    .HasFillFactor(90);

                entity.HasIndex(e => new { e.Id, e.ZoneId, e.Suburb, e.CostingZoneId }, "_dta_index_Location_5_2074594579__K1_K17_K16_K19_2_3_5_6_13_14_15");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AddressFull).HasMaxLength(500);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostingZoneId).HasColumnName("CostingZoneID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DefaultCustomerId).HasColumnName("DefaultCustomerID");

                entity.Property(e => e.DefaultDepotId).HasColumnName("DefaultDepotID");

                entity.Property(e => e.DepotZoneId).HasColumnName("DepotZoneID");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.LocationTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("LocationTypeID")
                    .HasDefaultValueSql("(N'LCTN')");

                entity.Property(e => e.LocationUseTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("LocationUseTypeID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ParentId).HasColumnName("ParentID");

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(10);

                entity.Property(e => e.PricingZoneId).HasColumnName("PricingZoneID");

                entity.Property(e => e.ReceiveEtaemail).HasColumnName("ReceiveETAEmail");

                entity.Property(e => e.State).HasMaxLength(10);

                entity.Property(e => e.Timezone).HasMaxLength(100);

                entity.Property(e => e.TypeNote).HasMaxLength(10);

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_Company");

                entity.HasOne(d => d.CostingZone)
                    .WithMany(p => p.LocationCostingZones)
                    .HasForeignKey(d => d.CostingZoneId)
                    .HasConstraintName("FK_Location_Zone2");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_Country");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.LocationCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Location_Customer");

                entity.HasOne(d => d.DefaultCustomer)
                    .WithMany(p => p.LocationDefaultCustomers)
                    .HasForeignKey(d => d.DefaultCustomerId)
                    .HasConstraintName("FK_Location_DefaultCustomer");

                entity.HasOne(d => d.DefaultDepot)
                    .WithMany(p => p.InverseDefaultDepot)
                    .HasForeignKey(d => d.DefaultDepotId)
                    .HasConstraintName("FK_Location_DefaultDepot");

                entity.HasOne(d => d.DepotZone)
                    .WithMany(p => p.LocationDepotZones)
                    .HasForeignKey(d => d.DepotZoneId)
                    .HasConstraintName("FK_Location_Zone3");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.LocationGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_Location_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.LocationGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_Location_Group2");

                entity.HasOne(d => d.LocationType)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.LocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Location_LocationType");

                entity.HasOne(d => d.LocationUseType)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.LocationUseTypeId)
                    .HasConstraintName("FK_Location_LocationUseType");

                entity.HasOne(d => d.PricingZone)
                    .WithMany(p => p.LocationPricingZones)
                    .HasForeignKey(d => d.PricingZoneId)
                    .HasConstraintName("FK_Location_Zone1");

                entity.HasOne(d => d.StateNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.State)
                    .HasConstraintName("FK_Location_State");

                entity.HasOne(d => d.SuburbNavigation)
                    .WithMany(p => p.Locations)
                    .HasForeignKey(d => d.Suburb)
                    .HasConstraintName("FK_Location_Suburbs");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.LocationZones)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_Location_Zone");
            });

            modelBuilder.Entity<LocationPolygon>(entity =>
            {
                entity.ToTable("LocationPolygon");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.LocationPolygons)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LocationPolygon_Location");
            });

            modelBuilder.Entity<LocationType>(entity =>
            {
                entity.ToTable("LocationType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<LocationUseType>(entity =>
            {
                entity.ToTable("LocationUseType");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasIndex(e => e.TimeStamp, "IxLogsTimeStamp");

                entity.Property(e => e.CompanyCode).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.Ipaddress)
                    .HasMaxLength(200)
                    .HasColumnName("IPAddress");

                entity.Property(e => e.Level).HasMaxLength(128);

                entity.Property(e => e.Module).HasMaxLength(200);

                entity.Property(e => e.Properties).HasColumnType("xml");

                entity.Property(e => e.Token).HasMaxLength(100);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<Manifest>(entity =>
            {
                entity.ToTable("Manifest");

                entity.HasIndex(e => e.TimeStamp, "IX_Manifest_TimeStamp");

                entity.HasIndex(e => e.Id, "_dta_index_Manifest_5_1467256382__K1_5_12");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Cost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CostingStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("CostingStatusID");

                entity.Property(e => e.CustomerHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DriverBreak1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DriverBreak2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DriverHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.Finish).HasColumnType("datetime");

                entity.Property(e => e.FleetConfigurationId).HasColumnName("FleetConfigurationID");

                entity.Property(e => e.FoxProManifestNumber).HasMaxLength(50);

                entity.Property(e => e.ManifestHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManifestKilometers).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ManifestNumber).HasMaxLength(50);

                entity.Property(e => e.ManifestStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("ManifestStatusID");

                entity.Property(e => e.ManifestType).HasMaxLength(3);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.ReturnTime).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.Property(e => e.Start).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.TimeToSite).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Trailer1Id).HasColumnName("Trailer1ID");

                entity.Property(e => e.Trailer2Id).HasColumnName("Trailer2ID");

                entity.Property(e => e.TrailerConfigurationId).HasColumnName("TrailerConfigurationID");

                entity.Property(e => e.TrailerConfigurationOld).HasMaxLength(250);

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Manifest_Company");

                entity.HasOne(d => d.CostingStatus)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.CostingStatusId)
                    .HasConstraintName("FK_Manifest_CostingStatus");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.DriverId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Manifest_User");

                entity.HasOne(d => d.FleetConfiguration)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.FleetConfigurationId)
                    .HasConstraintName("FK_Manifest_FleetConfiguration");

                entity.HasOne(d => d.LinehaulManifestFromNavigation)
                    .WithMany(p => p.ManifestLinehaulManifestFromNavigations)
                    .HasForeignKey(d => d.LinehaulManifestFrom)
                    .HasConstraintName("FK_Manifest_Location");

                entity.HasOne(d => d.LinehaulManifestToNavigation)
                    .WithMany(p => p.ManifestLinehaulManifestToNavigations)
                    .HasForeignKey(d => d.LinehaulManifestTo)
                    .HasConstraintName("FK_Manifest_Location1");

                entity.HasOne(d => d.ManifestStatus)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.ManifestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Manifest_ManifestStatus");

                entity.HasOne(d => d.ManifestTypeNavigation)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.ManifestType)
                    .HasConstraintName("FK_Manifest_ManifestType");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .HasConstraintName("FK_Manifest_PanelInvoice");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .HasConstraintName("FK_Manifest_ServiceCode");

                entity.HasOne(d => d.Trailer1)
                    .WithMany(p => p.ManifestTrailer1s)
                    .HasForeignKey(d => d.Trailer1Id)
                    .HasConstraintName("FK_Manifest_Vehicle1");

                entity.HasOne(d => d.Trailer2)
                    .WithMany(p => p.ManifestTrailer2s)
                    .HasForeignKey(d => d.Trailer2Id)
                    .HasConstraintName("FK_Manifest_Vehicle2");

                entity.HasOne(d => d.TrailerConfiguration)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.TrailerConfigurationId)
                    .HasConstraintName("FK_TrailerConfigurationManifestID");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.ManifestVehicles)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("FK_Manifest_Vehicle");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.Manifests)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_Manifest_Zone");
            });

            modelBuilder.Entity<ManifestHistory>(entity =>
            {
                entity.ToTable("ManifestHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DeviceTimestamp).HasColumnType("datetime");

                entity.Property(e => e.IpAddress).HasMaxLength(15);

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.ManifestStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("ManifestStatusID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampUtc)
                    .HasColumnType("datetime")
                    .HasColumnName("TimestampUTC");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.ManifestHistories)
                    .HasForeignKey(d => d.ManifestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestHistory_Manifest");

                entity.HasOne(d => d.ManifestStatus)
                    .WithMany(p => p.ManifestHistories)
                    .HasForeignKey(d => d.ManifestStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestHistory_ManifestStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ManifestHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_ManifestHistory_WebPanelUser");
            });

            modelBuilder.Entity<ManifestName>(entity =>
            {
                entity.ToTable("ManifestName");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ManifestNames)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ManifestName_Company");
            });

            modelBuilder.Entity<ManifestStatus>(entity =>
            {
                entity.ToTable("ManifestStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Color)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ManifestType>(entity =>
            {
                entity.HasKey(e => e.Code)
                    .HasName("PK__Manifest__A25C5AA62C0A9ACD");

                entity.ToTable("ManifestType");

                entity.Property(e => e.Code).HasMaxLength(3);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<MapDefaultCentre>(entity =>
            {
                entity.ToTable("MapDefaultCentre");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<MassManagement>(entity =>
            {
                entity.ToTable("MassManagement");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Drive).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GrossWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadingTimestamp).HasColumnType("datetime");

                entity.Property(e => e.Steer).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Trailer1Id).HasColumnName("Trailer1ID");

                entity.Property(e => e.Trailer2Id).HasColumnName("Trailer2ID");

                entity.Property(e => e.TriAxle1).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.TriAxle2).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Trailer1)
                    .WithMany(p => p.MassManagementTrailer1s)
                    .HasForeignKey(d => d.Trailer1Id)
                    .HasConstraintName("FK_MassManagement_Vehicle1");

                entity.HasOne(d => d.Trailer2)
                    .WithMany(p => p.MassManagementTrailer2s)
                    .HasForeignKey(d => d.Trailer2Id)
                    .HasConstraintName("FK_MassManagement_Vehicle2");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.MassManagementVehicles)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MassManagement_Vehicle");
            });

            modelBuilder.Entity<MassManagementJobLeg>(entity =>
            {
                entity.ToTable("MassManagementJobLeg");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.MassManagementId).HasColumnName("MassManagementID");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.MassManagementJobLegs)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MassManagementJobLeg_JobLeg");

                entity.HasOne(d => d.MassManagement)
                    .WithMany(p => p.MassManagementJobLegs)
                    .HasForeignKey(d => d.MassManagementId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MassManagementJobLeg_MassManagement");
            });

            modelBuilder.Entity<Message>(entity =>
            {
                entity.ToTable("Message");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ConversationId).HasColumnName("ConversationID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampAcknowledged).HasColumnType("datetime");

                entity.Property(e => e.TimestampRead).HasColumnType("datetime");

                entity.HasOne(d => d.Conversation)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.ConversationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_ConversationParticipant");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.Messages)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Message_User");
            });

            modelBuilder.Entity<Messaging>(entity =>
            {
                entity.ToTable("Messaging");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RecipientId).HasColumnName("RecipientID");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.TimestampAcknowledged).HasColumnType("datetime");

                entity.Property(e => e.TimestampRead).HasColumnType("datetime");

                entity.HasOne(d => d.Recipient)
                    .WithMany(p => p.MessagingRecipients)
                    .HasForeignKey(d => d.RecipientId)
                    .HasConstraintName("FK_Messaging_User1");

                entity.HasOne(d => d.Sender)
                    .WithMany(p => p.MessagingSenders)
                    .HasForeignKey(d => d.SenderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Messaging_User");
            });

            modelBuilder.Entity<Mileage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Mileage");

                entity.Property(e => e.DestinationCity)
                    .HasMaxLength(255)
                    .HasColumnName("DESTINATION_CITY");

                entity.Property(e => e.DestinationProvin)
                    .HasMaxLength(255)
                    .HasColumnName("DESTINATION_PROVIN");

                entity.Property(e => e.Distance).HasColumnName("DISTANCE");

                entity.Property(e => e.FlatPayAmt).HasColumnName("FLAT_PAY_AMT");

                entity.Property(e => e.OriginCity)
                    .HasMaxLength(255)
                    .HasColumnName("ORIGIN_CITY");

                entity.Property(e => e.OriginProvince)
                    .HasMaxLength(255)
                    .HasColumnName("ORIGIN_PROVINCE");

                entity.Property(e => e.RouteMode)
                    .HasMaxLength(255)
                    .HasColumnName("ROUTE_MODE");

                entity.Property(e => e.Source)
                    .HasMaxLength(255)
                    .HasColumnName("SOURCE");

                entity.Property(e => e.Tolls).HasColumnName("TOLLS");
            });

            modelBuilder.Entity<MobileDevice>(entity =>
            {
                entity.ToTable("MobileDevice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.MobileDevices)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MobileDevice_Company");
            });

            modelBuilder.Entity<MobileLog>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.DeviceTimestamp).HasColumnType("datetime");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.LegId).HasColumnName("LegID");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.HasOne(d => d.Leg)
                    .WithMany(p => p.MobileLogs)
                    .HasForeignKey(d => d.LegId)
                    .HasConstraintName("FK_MobileLogs_JobLeg");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.MobileLogs)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_MobileLogs_Manifest");
            });

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CreatedBy).HasMaxLength(50);

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.Note1)
                    .HasColumnType("text")
                    .HasColumnName("Note");

                entity.Property(e => e.NoteType).HasMaxLength(50);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.CreatedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Notes_WebPanelUser");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.Notes)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Notes_Job");
            });

            modelBuilder.Entity<Notification>(entity =>
            {
                entity.ToTable("Notification");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AcknowledgeSentDateTime).HasColumnType("datetime");

                entity.Property(e => e.Acknowledged).HasColumnType("datetime");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.Property(e => e.ReceiverUserId).HasColumnName("ReceiverUserID");

                entity.Property(e => e.SenderUserId).HasColumnName("SenderUserID");

                entity.Property(e => e.Sound).HasMaxLength(20);

                entity.Property(e => e.Title).HasMaxLength(100);

                entity.Property(e => e.Type).HasMaxLength(10);

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.Notifications)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_Notification_Manifest");
            });

            modelBuilder.Entity<OdometerReading>(entity =>
            {
                entity.ToTable("OdometerReading");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ReadingOnFinish).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadingOnStart).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ReadingTimestamp).HasColumnType("datetime");

                entity.Property(e => e.VehicleId).HasColumnName("VehicleID");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.OdometerReadings)
                    .HasForeignKey(d => d.VehicleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OdometerReading_Vehicle");
            });

            modelBuilder.Entity<OdometerReadingJobLeg>(entity =>
            {
                entity.ToTable("OdometerReadingJobLeg");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.OdometerReadingId).HasColumnName("OdometerReadingID");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.OdometerReadingJobLegs)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OdometerReadingJobLeg_JobLeg");

                entity.HasOne(d => d.OdometerReading)
                    .WithMany(p => p.OdometerReadingJobLegs)
                    .HasForeignKey(d => d.OdometerReadingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_OdometerReadingJobLeg_OdometerReading");
            });

            modelBuilder.Entity<OpeningHour>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CloseTime).HasMaxLength(20);

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.OpenTime).HasMaxLength(20);

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.OpeningHours)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK__OpeningHo__Locat__4C0C31DC");
            });

            modelBuilder.Entity<PalletAccount>(entity =>
            {
                entity.ToTable("PalletAccount");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PalletCompany).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PalletAccounts)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK__PalletAcc__Compa__4D005615");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PalletAccounts)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__PalletAcc__Custo__4DF47A4E");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PalletAccounts)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_PalletAccount_Location");
            });

            modelBuilder.Entity<PalletAddressAccount>(entity =>
            {
                entity.ToTable("PalletAddressAccount");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PalletAccountId).HasColumnName("PalletAccountID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PalletAddressAccounts)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_LocationID");

                entity.HasOne(d => d.PalletAccount)
                    .WithMany(p => p.PalletAddressAccounts)
                    .HasForeignKey(d => d.PalletAccountId)
                    .HasConstraintName("FK_PalletAccountID");
            });

            modelBuilder.Entity<PalletMovementType>(entity =>
            {
                entity.ToTable("PalletMovementType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<PalletTransaction>(entity =>
            {
                entity.ToTable("PalletTransaction");

                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.PalletType)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Reference).HasMaxLength(255);

                entity.Property(e => e.Type).HasMaxLength(50);

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.PalletTransactions)
                    .HasForeignKey(d => d.JobLegId)
                    .HasConstraintName("FK_PalletTransaction_JobLeg");

                entity.HasOne(d => d.MovementTypeNavigation)
                    .WithMany(p => p.PalletTransactions)
                    .HasForeignKey(d => d.MovementType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PalletTransaction_MovementType");

                entity.HasOne(d => d.PalletTypeNavigation)
                    .WithMany(p => p.PalletTransactions)
                    .HasForeignKey(d => d.PalletType)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PalletTransaction_PalletType");
            });

            modelBuilder.Entity<PalletType>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PanelInvoice>(entity =>
            {
                entity.ToTable("PanelInvoice");

                entity.HasIndex(e => e.DueDate, "IX_DueDate");

                entity.HasIndex(e => new { e.CustomerId, e.InvoiceDate }, "PaneInvoice_CustID_InvDat");

                entity.HasIndex(e => e.CredNoteSalesLedger, "PanelInvoice_CreditNoteID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountRef).HasMaxLength(30);

                entity.Property(e => e.AccountingSystemId).HasColumnName("AccountingSystemID");

                entity.Property(e => e.AccountingSystemInstanceId).HasColumnName("AccountingSystemInstanceID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostCentre).HasMaxLength(100);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gst).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.GstRate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.InvoiceBatchId).HasColumnName("InvoiceBatchID");

                entity.Property(e => e.InvoiceDate).HasColumnType("datetime");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.Nett).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PanelInvoiceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("PanelInvoiceStatusID");

                entity.Property(e => e.PanelInvoiceTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("PanelInvoiceTypeID")
                    .HasDefaultValueSql("('TRNSP')");

                entity.Property(e => e.SpabatchId).HasColumnName("SPABatchID");

                entity.Property(e => e.SpanumberInt).HasColumnName("SPANumberInt");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.AccountingSystemInstance)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.AccountingSystemInstanceId)
                    .HasConstraintName("FK_Invoice_AccSystemInstance");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoice_Company");

                entity.HasOne(d => d.CredNoteSalesLedgerNavigation)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.CredNoteSalesLedger)
                    .HasConstraintName("FK_PanelInvoice_CreditNoteSalesLedger");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_PanelInvoice_Customer");

                entity.HasOne(d => d.InvoiceBatch)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.InvoiceBatchId)
                    .HasConstraintName("FK_PanelInvoice_InvoiceBatch");

                entity.HasOne(d => d.PanelInvoiceStatus)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.PanelInvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoice_PanelInvoiceStatus");

                entity.HasOne(d => d.PanelInvoiceType)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.PanelInvoiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoice_PanelInvoiceType");

                entity.HasOne(d => d.Spabatch)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.SpabatchId)
                    .HasConstraintName("FK_PanelInvoice_SPABatch");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_PanelInvoice_Subcontractor");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PanelInvoices)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoice_WebPanelUser");
            });

            modelBuilder.Entity<PanelInvoiceDeletedJob>(entity =>
            {
                entity.ToTable("PanelInvoiceDeletedJob");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.PanelInvoiceDeletedJobs)
                    .HasForeignKey(d => d.JobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceDeletedJob_Job");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.PanelInvoiceDeletedJobs)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceDeletedJob_PanelInvoice");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PanelInvoiceDeletedJobs)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceDeletedJob_WebPanelUser");
            });

            modelBuilder.Entity<PanelInvoiceHistory>(entity =>
            {
                entity.ToTable("PanelInvoiceHistory");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceStatusID");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.InvoiceStatus)
                    .WithMany(p => p.PanelInvoiceHistories)
                    .HasForeignKey(d => d.InvoiceStatusId)
                    .HasConstraintName("FK_PanelInvoiceHistory_PanelInvoiceStatus");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.PanelInvoiceHistories)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceHistory_PanelInvoice");
            });

            modelBuilder.Entity<PanelInvoiceStatus>(entity =>
            {
                entity.ToTable("PanelInvoiceStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PanelInvoiceStatusName>(entity =>
            {
                entity.ToTable("PanelInvoiceStatusName");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AccountingSystemId)
                    .HasMaxLength(10)
                    .HasColumnName("AccountingSystemID");

                entity.Property(e => e.InterfaceTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("InterfaceTypeID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PanelInvoiceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("PanelInvoiceStatusID");

                entity.HasOne(d => d.AccountingSystem)
                    .WithMany(p => p.PanelInvoiceStatusNames)
                    .HasForeignKey(d => d.AccountingSystemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceStatusName_AccountingSystem");

                entity.HasOne(d => d.InterfaceType)
                    .WithMany(p => p.PanelInvoiceStatusNames)
                    .HasForeignKey(d => d.InterfaceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceStatusName_InterfaceType");

                entity.HasOne(d => d.PanelInvoiceStatus)
                    .WithMany(p => p.PanelInvoiceStatusNames)
                    .HasForeignKey(d => d.PanelInvoiceStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PanelInvoiceStatusName_PanelInvoiceStatus");
            });

            modelBuilder.Entity<PanelInvoiceType>(entity =>
            {
                entity.ToTable("PanelInvoiceType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<PanelInvoiceView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("PanelInvoiceView");

                entity.Property(e => e.AccountName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AccountRef).HasMaxLength(30);

                entity.Property(e => e.BatchId).HasColumnName("BatchID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Customer).HasMaxLength(200);

                entity.Property(e => e.CustomerAccountingSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DueAmount).HasColumnType("decimal(38, 2)");

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Gst).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.InvoiceAccountingSystem)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InvoiceDeliveryMethod).HasMaxLength(50);

                entity.Property(e => e.InvoiceDeliveryMethodId)
                    .HasMaxLength(10)
                    .HasColumnName("InvoiceDeliveryMethodID");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.InvoiceType).HasMaxLength(100);

                entity.Property(e => e.InvoiceXeroId).HasColumnName("InvoiceXeroID");

                entity.Property(e => e.LastStatus).HasMaxLength(50);

                entity.Property(e => e.LastStatusColor).HasMaxLength(50);

                entity.Property(e => e.LastStatusDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("LastStatusID");

                entity.Property(e => e.Nett).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Status).HasMaxLength(50);

                entity.Property(e => e.StatusId)
                    .HasMaxLength(10)
                    .HasColumnName("StatusID");
            });

            modelBuilder.Entity<Payment>(entity =>
            {
                entity.ToTable("Payment");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.PaymentNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentStatusId)
                    .HasColumnName("PaymentStatusID")
                    .HasDefaultValueSql("('49314A30-B199-4CC0-94A3-FB345FD42147')");

                entity.Property(e => e.PaymentTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("PaymentTypeID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_Customer");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Payment_PanelInvoice");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .HasConstraintName("FK_PanelInvoice_PaymentStatus");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_Payment_PaymentType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Payments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Payment_WebPanelUser");
            });

            modelBuilder.Entity<PaymentItem>(entity =>
            {
                entity.ToTable("PaymentItem");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Gross).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PanelInvoiceId).HasColumnName("PanelInvoiceID");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.PanelInvoice)
                    .WithMany(p => p.PaymentItems)
                    .HasForeignKey(d => d.PanelInvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentItem_PanelInvoice");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentItems)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentItem_Payment");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PaymentItems)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentItem_WebPanelUser");
            });

            modelBuilder.Entity<PaymentReconciliation>(entity =>
            {
                entity.ToTable("PaymentReconciliation");

                entity.HasIndex(e => e.InvoiceId, "PaymentReconciliation_InvoiceID");

                entity.HasIndex(e => e.PaymentId, "PaymentReconciliation_PaymentID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.AmountReconciled).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PaymentReconciliations)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reconciliation_PanelInvoice");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.PaymentReconciliations)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_Reconciliation_Job");

                entity.HasOne(d => d.Payment)
                    .WithMany(p => p.PaymentReconciliations)
                    .HasForeignKey(d => d.PaymentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reconciliation_Payment");
            });

            modelBuilder.Entity<PaymentSalesLedger>(entity =>
            {
                entity.ToTable("PaymentSalesLedger");

                entity.HasIndex(e => new { e.AccountNameId, e.Date }, "PaymentSalesLedger_CustID_Date");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountNameId).HasColumnName("AccountNameID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountReconciled).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.AmountRounded).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DefaultAccountId).HasColumnName("DefaultAccountID");

                entity.Property(e => e.ExportedPaymentId).HasColumnName("ExportedPaymentID");

                entity.Property(e => e.ExportedTimestamp).HasColumnType("datetime");

                entity.Property(e => e.OriginalAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PaymentNumber).HasMaxLength(50);

                entity.Property(e => e.PaymentStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("PaymentStatusID");

                entity.Property(e => e.PaymentTypeId)
                    .HasMaxLength(10)
                    .HasColumnName("PaymentTypeID");

                entity.Property(e => e.ReversedPaymentId).HasColumnName("ReversedPaymentID");

                entity.Property(e => e.StripePaymentId)
                    .HasMaxLength(250)
                    .HasColumnName("StripePaymentID");

                entity.Property(e => e.StripeReceiptUrl)
                    .HasMaxLength(500)
                    .HasColumnName("StripeReceiptURL");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.AccountName)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.AccountNameId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentSL_CustomerAccount");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentSL_Company");

                entity.HasOne(d => d.DefaultAccount)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.DefaultAccountId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentSL_DefaultAccount");

                entity.HasOne(d => d.ExportedPayment)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.ExportedPaymentId)
                    .HasConstraintName("FK_PaymentSalesLedger_ExportedPayment");

                entity.HasOne(d => d.PaymentStatus)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.PaymentStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentSL_PaymentStatus");

                entity.HasOne(d => d.PaymentType)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.PaymentTypeId)
                    .HasConstraintName("FK_PaymentSL_PaymentType");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PaymentSalesLedgers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PaymentSL_WebPanelUser");
            });

            modelBuilder.Entity<PaymentStatus>(entity =>
            {
                entity.ToTable("PaymentStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentStatusSalesLedger>(entity =>
            {
                entity.ToTable("PaymentStatusSalesLedger");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<PaymentTerm>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PaymentType>(entity =>
            {
                entity.ToTable("PaymentType");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.AvailableToSalesLedger)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PersonalCustomerLocation>(entity =>
            {
                entity.ToTable("PersonalCustomerLocation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.PersonalLocationTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("PersonalLocationTypeID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PersonalCustomerLocations)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalCustomerLocation_Customer");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.PersonalCustomerLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalCustomerLocation_Location");

                entity.HasOne(d => d.PersonalLocationType)
                    .WithMany(p => p.PersonalCustomerLocations)
                    .HasForeignKey(d => d.PersonalLocationTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PersonalCustomerLocation_PersonalLocationType");
            });

            modelBuilder.Entity<PersonalLocationType>(entity =>
            {
                entity.ToTable("PersonalLocationType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Podexception>(entity =>
            {
                entity.ToTable("PODException");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PodstatusId)
                    .HasMaxLength(5)
                    .HasColumnName("PODStatusID");

                entity.HasOne(d => d.Podstatus)
                    .WithMany(p => p.Podexceptions)
                    .HasForeignKey(d => d.PodstatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PODException_PODStatus");
            });

            modelBuilder.Entity<Podphoto>(entity =>
            {
                entity.ToTable("PODPhoto");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.Podphotos)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PODPhoto_JobLeg");
            });

            modelBuilder.Entity<Podsignature>(entity =>
            {
                entity.ToTable("PODSignature");

                entity.HasIndex(e => e.JobLegId, "IX_PODSignature_JobLebId");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Kind).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.Podsignatures)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PODSignature_JobLeg");
            });

            modelBuilder.Entity<Podstatus>(entity =>
            {
                entity.ToTable("PODStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PriceJobTotal>(entity =>
            {
                entity.HasIndex(e => e.ChargeUnitId, "NC_ChargeUnitID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ServiceCodeId, "NC_ServiceCodeID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ServiceLaneId, "NC_ServiceLaneID")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasMaxLength(10);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MaxCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.Property(e => e.ServiceLaneId).HasColumnName("ServiceLaneID");

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.PriceJobTotals)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceJobTotals_PricingChargeUnit");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.PriceJobTotals)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .HasConstraintName("FK_PriceJobTotals_ServiceCode");

                entity.HasOne(d => d.ServiceLane)
                    .WithMany(p => p.PriceJobTotals)
                    .HasForeignKey(d => d.ServiceLaneId)
                    .HasConstraintName("FK_PriceJobTotals_ServiceLane");
            });

            modelBuilder.Entity<PriceProductCard>(entity =>
            {
                entity.ToTable("PriceProductCard");

                entity.HasIndex(e => e.ChargeUnitId, "NC_ChargeUnit")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PricingUnitId, "NC_PricingUnit")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ServiceCodeId, "NC_ServiceCode")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ServiceLaneId, "NC_ServiceLaneID")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasMaxLength(10);

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.MaxCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.PricingUnitId).HasColumnName("PricingUnitID");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.Property(e => e.ServiceLaneId).HasColumnName("ServiceLaneID");

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.PriceProductCards)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceProductCard_PricingChargeUnit");

                entity.HasOne(d => d.PricingUnit)
                    .WithMany(p => p.PriceProductCards)
                    .HasForeignKey(d => d.PricingUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PriceProductCard_Product");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.PriceProductCards)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .HasConstraintName("FK_PriceProductCard_ServiceCode");

                entity.HasOne(d => d.ServiceLane)
                    .WithMany(p => p.PriceProductCards)
                    .HasForeignKey(d => d.ServiceLaneId)
                    .HasConstraintName("FK_PriceProductCard_ServiceLane");
            });

            modelBuilder.Entity<Pricing>(entity =>
            {
                entity.ToTable("Pricing");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.Account).HasMaxLength(10);

                entity.Property(e => e.AccountingSystem).IsUnicode(false);

                entity.Property(e => e.ChargeUnitId)
                    .HasMaxLength(10)
                    .HasColumnName("ChargeUnitID");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DefQty).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.DefaultUnitRate).HasColumnType("decimal(18, 4)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.JobCodeId).HasColumnName("JobCodeID");

                entity.Property(e => e.ModifiedBy)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("(N'transfocus')");

                entity.Property(e => e.ModifiedOn)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.PricingCodeXero).IsUnicode(false);

                entity.Property(e => e.ServiceLaneId).HasColumnName("ServiceLaneID");

                entity.Property(e => e.ShowRate)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.TaxRate)
                    .HasColumnType("decimal(10, 2)")
                    .HasDefaultValueSql("((10))");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.Property(e => e.XeroAccountCode).HasMaxLength(10);

                entity.HasOne(d => d.ChargeUnit)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.ChargeUnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pricing_PricingChargeUnit");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Pricing_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Pricing_Customer");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.PricingGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_Pricing_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.PricingGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_Pricing_Group2");

                entity.HasOne(d => d.Gstcode)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.GstcodeId)
                    .HasConstraintName("FK_Pricing_GSTCode");

                entity.HasOne(d => d.JobCode)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.JobCodeId)
                    .HasConstraintName("FK_Pricing_JobCode");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Pricing_WebPanelUser");

                entity.HasOne(d => d.PriceProductCard)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.PriceProductCardId)
                    .HasConstraintName("FK_Pricing_PriceProductCard");

                entity.HasOne(d => d.ServiceLane)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.ServiceLaneId)
                    .HasConstraintName("FK_Pricing_ServiceLane");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.Pricings)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_Pricing_Subcontractors");
            });

            modelBuilder.Entity<PricingChargeUnit>(entity =>
            {
                entity.ToTable("PricingChargeUnit");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PricingDependence>(entity =>
            {
                entity.ToTable("PricingDependence");

                entity.HasIndex(e => e.PricingId, "IX_PricingDependence");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DependedId).HasColumnName("DependedID");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.HasOne(d => d.Depended)
                    .WithMany(p => p.PricingDependenceDependeds)
                    .HasForeignKey(d => d.DependedId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingDependence_Pricing1");

                entity.HasOne(d => d.Pricing)
                    .WithMany(p => p.PricingDependencePricings)
                    .HasForeignKey(d => d.PricingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingDependence_Pricing");
            });

            modelBuilder.Entity<PricingHistory>(entity =>
            {
                entity.ToTable("PricingHistory");

                entity.HasIndex(e => e.EffectiveDate, "IX_PricingHistory");

                entity.HasIndex(e => e.ExpiryDate, "IX_PricingHistory_1");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.Rate).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Pricing)
                    .WithMany(p => p.PricingHistories)
                    .HasForeignKey(d => d.PricingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingHistory_Pricing");
            });

            modelBuilder.Entity<PricingInvoice>(entity =>
            {
                entity.ToTable("PricingInvoice");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.ChargeUnit).HasMaxLength(10);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GstcodeId).HasColumnName("GSTCodeID");

                entity.Property(e => e.InvoiceId).HasColumnName("InvoiceID");

                entity.Property(e => e.InvoiceNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.PricingItemId).HasColumnName("PricingItemID");

                entity.Property(e => e.Quantity).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.TaxRate).HasColumnType("decimal(10, 0)");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UnitRate).HasColumnType("decimal(18, 4)");

                entity.HasOne(d => d.ChargeUnitNavigation)
                    .WithMany(p => p.PricingInvoices)
                    .HasForeignKey(d => d.ChargeUnit)
                    .HasConstraintName("FK_PricingInvoice_PricingChargeUnit");

                entity.HasOne(d => d.Gstcode)
                    .WithMany(p => p.PricingInvoices)
                    .HasForeignKey(d => d.GstcodeId)
                    .HasConstraintName("FK_PricingInvoice_GSTCode");

                entity.HasOne(d => d.Invoice)
                    .WithMany(p => p.PricingInvoices)
                    .HasForeignKey(d => d.InvoiceId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingInvoice_PanelInvoice");

                entity.HasOne(d => d.PricingItem)
                    .WithMany(p => p.PricingInvoices)
                    .HasForeignKey(d => d.PricingItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingInvoice_Pricing");
            });

            modelBuilder.Entity<PricingSchedule>(entity =>
            {
                entity.ToTable("PricingSchedule");

                entity.HasIndex(e => e.CompanyId, "NC_ComapnyID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PricingScheduleStatusId, "NC_PricingScheduleStatusID")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.PricingScheduleStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("PricingScheduleStatusID");

                entity.Property(e => e.PricingScheduleTypeId).HasColumnName("PricingScheduleTypeID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PricingSchedules)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingSchedule_Company");

                entity.HasOne(d => d.PricingScheduleStatus)
                    .WithMany(p => p.PricingSchedules)
                    .HasForeignKey(d => d.PricingScheduleStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingSchedule_PricingScheduleStatus");

                entity.HasOne(d => d.PricingScheduleType)
                    .WithMany(p => p.PricingSchedules)
                    .HasForeignKey(d => d.PricingScheduleTypeId)
                    .HasConstraintName("FK_PricingSchedule_PricingScheduleType");
            });

            modelBuilder.Entity<PricingScheduleCustomer>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.PricingScheduleId).HasColumnName("PricingScheduleID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.PricingScheduleCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingScheduleCustomers_Customer");

                entity.HasOne(d => d.PricingSchedule)
                    .WithMany(p => p.PricingScheduleCustomers)
                    .HasForeignKey(d => d.PricingScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingScheduleCustomers_PricingSchedule");
            });

            modelBuilder.Entity<PricingScheduleStatus>(entity =>
            {
                entity.ToTable("PricingScheduleStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<PricingScheduleType>(entity =>
            {
                entity.ToTable("PricingScheduleType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PricingScheduleTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PricingScheduleType_Company");
            });

            modelBuilder.Entity<PricingStatus>(entity =>
            {
                entity.ToTable("PricingStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.ToTable("Product");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Account).HasMaxLength(10);

                entity.Property(e => e.AllowEntryIfValidationFails)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(100);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Cubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Delweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("DELWeight");

                entity.Property(e => e.Depth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.GroupId)
                    .HasMaxLength(50)
                    .HasColumnName("GroupID");

                entity.Property(e => e.Height).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxCubic).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxDepth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxHeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxSpace).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MaxWidth).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Otweight)
                    .HasColumnType("decimal(18, 2)")
                    .HasColumnName("OTWeight");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.PricingUnit).HasMaxLength(100);

                entity.Property(e => e.PricingUnitId).HasColumnName("PricingUnitID");

                entity.Property(e => e.ProductCode).HasMaxLength(100);

                entity.Property(e => e.QuantityPerUnit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Reference).HasMaxLength(50);

                entity.Property(e => e.ShippingUnit)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Space).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Weight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Width).HasColumnType("decimal(18, 2)");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Product_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Product_Customer");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.ProductGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_Product_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.ProductGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_Product_Group2");

                entity.HasOne(d => d.Pricing)
                    .WithMany(p => p.Products)
                    .HasForeignKey(d => d.PricingId)
                    .HasConstraintName("FK_Product_Pricing");
            });

            modelBuilder.Entity<ProductLocation>(entity =>
            {
                entity.ToTable("ProductLocation");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ProductLocations)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_ProductLocation_Company");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.ProductLocations)
                    .HasForeignKey(d => d.LocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLocation_Location");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ProductLocations)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProductLocation_Product");
            });

            modelBuilder.Entity<ProductPriceEnquiryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ProductPriceEnquiryView");

                entity.Property(e => e.ChargeUnit).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.EffectiveDate).HasColumnType("date");

                entity.Property(e => e.ExpiryDate).HasColumnType("date");

                entity.Property(e => e.FromZone).HasMaxLength(200);

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MaxCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.MinCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.OptionalPricing)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OptionalPricingDescription).HasMaxLength(200);

                entity.Property(e => e.PricingUnit).HasMaxLength(100);

                entity.Property(e => e.ScheduleName).HasMaxLength(200);

                entity.Property(e => e.Service).HasMaxLength(100);

                entity.Property(e => e.ToZone).HasMaxLength(200);
            });

            modelBuilder.Entity<PublicHoliday>(entity =>
            {
                entity.ToTable("PublicHoliday");

                entity.HasIndex(e => new { e.CountryId, e.CompanyId, e.HolidayDate }, "CompanyCountryDate")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.HolidayDate).HasColumnType("date");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.PublicHolidays)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_PublicHoliday_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.PublicHolidays)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_PublicHoliday_Country");
            });

            modelBuilder.Entity<RangePricing>(entity =>
            {
                entity.ToTable("RangePricing");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DateFrom).HasColumnType("date");

                entity.Property(e => e.DateTo).HasColumnType("date");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.PricingId).HasColumnName("PricingID");

                entity.Property(e => e.Rate).HasColumnType("decimal(10, 2)");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.RangePricings)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_RangePricing_Customer");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.RangePricings)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RangePricing_WebPanelUser");

                entity.HasOne(d => d.Pricing)
                    .WithMany(p => p.RangePricings)
                    .HasForeignKey(d => d.PricingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RangePricing_Pricing");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.RangePricings)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .HasConstraintName("FK_RangePricing_ServiceCode");
            });

            modelBuilder.Entity<RapidCheckList>(entity =>
            {
                entity.ToTable("RapidCheckList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NotFitForWorkUntil).HasColumnType("datetime");

                entity.HasOne(d => d.AuthTokenNavigation)
                    .WithMany(p => p.RapidCheckLists)
                    .HasForeignKey(d => d.AuthToken)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RapidCheckList_AuthToken");
            });

            modelBuilder.Entity<RecurrenceJobList>(entity =>
            {
                entity.ToTable("RecurrenceJobList");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RecurrenceJobScheduleId).HasColumnName("RecurrenceJobScheduleID");

                entity.Property(e => e.SourceJobId).HasColumnName("SourceJobID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.RecurrenceJobSchedule)
                    .WithMany(p => p.RecurrenceJobLists)
                    .HasForeignKey(d => d.RecurrenceJobScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobList_RecurrenceJobSchedule");

                entity.HasOne(d => d.SourceJob)
                    .WithMany(p => p.RecurrenceJobLists)
                    .HasForeignKey(d => d.SourceJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobList_Job");
            });

            modelBuilder.Entity<RecurrenceJobSchedule>(entity =>
            {
                entity.ToTable("RecurrenceJobSchedule");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Detail).HasMaxLength(200);

                entity.Property(e => e.Frequency).HasMaxLength(10);

                entity.Property(e => e.FrequencyDetail).HasMaxLength(50);

                entity.Property(e => e.GenerateForWeekDays).HasMaxLength(50);

                entity.Property(e => e.Interval).HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ScheduleEnd).HasColumnType("datetime");

                entity.Property(e => e.ScheduleStart).HasColumnType("datetime");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.RecurrenceJobSchedules)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobSchedule_Company");
            });

            modelBuilder.Entity<RecurrenceJobScheduleRun>(entity =>
            {
                entity.ToTable("RecurrenceJobScheduleRun");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IpAddress).HasMaxLength(200);

                entity.Property(e => e.RecurrenceJobScheduleId).HasColumnName("RecurrenceJobScheduleID");

                entity.Property(e => e.RunTimeStamp).HasColumnType("datetime");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.RecurrenceJobSchedule)
                    .WithMany(p => p.RecurrenceJobScheduleRuns)
                    .HasForeignKey(d => d.RecurrenceJobScheduleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobScheduleRun_RecurrenceJobSchedule");
            });

            modelBuilder.Entity<RecurrenceJobScheduleRunHistory>(entity =>
            {
                entity.ToTable("RecurrenceJobScheduleRunHistory");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NewJobDate).HasColumnType("datetime");

                entity.Property(e => e.NewJobId).HasColumnName("NewJobID");

                entity.Property(e => e.RecurrenceJobScheduleRunId).HasColumnName("RecurrenceJobScheduleRunID");

                entity.Property(e => e.SourceJobId).HasColumnName("SourceJobID");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.NewJob)
                    .WithMany(p => p.RecurrenceJobScheduleRunHistoryNewJobs)
                    .HasForeignKey(d => d.NewJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobScheduleRunHistory_Job2");

                entity.HasOne(d => d.RecurrenceJobScheduleRun)
                    .WithMany(p => p.RecurrenceJobScheduleRunHistories)
                    .HasForeignKey(d => d.RecurrenceJobScheduleRunId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobScheduleRunHistory_RecurrenceJobScheduleRun");

                entity.HasOne(d => d.SourceJob)
                    .WithMany(p => p.RecurrenceJobScheduleRunHistorySourceJobs)
                    .HasForeignKey(d => d.SourceJobId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RecurrenceJobScheduleRunHistory_Job1");
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.ToTable("Reference");

                entity.HasIndex(e => e.TableId, "IX_TableID")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.RefValue).HasMaxLength(200);

                entity.Property(e => e.ReferenceTypeId).HasColumnName("ReferenceTypeID");

                entity.Property(e => e.TableId).HasColumnName("TableID");

                entity.HasOne(d => d.ReferenceType)
                    .WithMany(p => p.References)
                    .HasForeignKey(d => d.ReferenceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_ReferenceType");

                entity.HasOne(d => d.Table)
                    .WithMany(p => p.References)
                    .HasForeignKey(d => d.TableId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Reference_Job");
            });

            modelBuilder.Entity<ReferenceType>(entity =>
            {
                entity.ToTable("ReferenceType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(15);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.TableName).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ReferenceTypes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReferenceType_Company");
            });

            modelBuilder.Entity<Report>(entity =>
            {
                entity.ToTable("Report");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IsCommon)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.ReportType).HasMaxLength(10);

                entity.Property(e => e.SystemTypeName).HasMaxLength(200);
            });

            modelBuilder.Entity<ReportCompanyList>(entity =>
            {
                entity.ToTable("ReportCompanyList");

                entity.HasIndex(e => e.CompanyId, "ReportCompanyList_CompanyID");

                entity.HasIndex(e => e.ReportId, "ReportCompanyList_ReportID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ReportId).HasColumnName("ReportID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ReportCompanyLists)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportCompanyList_Company");

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.ReportCompanyLists)
                    .HasForeignKey(d => d.ReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportCompanyList_Report");
            });

            modelBuilder.Entity<ReportsApiauth>(entity =>
            {
                entity.ToTable("ReportsAPIAuth");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ExpiryDate).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ReportsApiauths)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportsAPIAuth_WebPanelUser");
            });

            modelBuilder.Entity<RevokedManifestJobLeg>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.RevokedManifestJobLegs)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevokedManifestJobLegs_JobLeg1");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.RevokedManifestJobLegs)
                    .HasForeignKey(d => d.ManifestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RevokedManifestJobLegs_Manifest1");
            });

            modelBuilder.Entity<RoadToll>(entity =>
            {
                entity.HasIndex(e => e.JobId, "RoadTolls_JobID");

                entity.HasIndex(e => e.ManifestId, "RoadTolls_ManifestID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GeneralTollsId).HasColumnName("GeneralTollsID");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.ManifestId).HasColumnName("ManifestID");

                entity.HasOne(d => d.GeneralTolls)
                    .WithMany(p => p.RoadTolls)
                    .HasForeignKey(d => d.GeneralTollsId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoadTolls_GeneralTolls");

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.RoadTolls)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_RoadTolls_Job");

                entity.HasOne(d => d.Manifest)
                    .WithMany(p => p.RoadTolls)
                    .HasForeignKey(d => d.ManifestId)
                    .HasConstraintName("FK_RoadTolls_Manifest");
            });

            modelBuilder.Entity<Schema>(entity =>
            {
                entity.HasKey(e => e.Version)
                    .HasName("PK_HangFire_Schema");

                entity.ToTable("Schema", "HangFire");

                entity.Property(e => e.Version).ValueGeneratedNever();
            });

            modelBuilder.Entity<SendInvoiceMethod>(entity =>
            {
                entity.ToTable("SendInvoiceMethod");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SenderSignature>(entity =>
            {
                entity.ToTable("SenderSignature");

                entity.HasIndex(e => e.JobLegId, "IX_SenderSignature_JobLegID");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.Kind).HasDefaultValueSql("((1))");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.SenderSignatures)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SenderSignature_JobLeg");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "HangFire");

                entity.HasIndex(e => e.LastHeartbeat, "IX_HangFire_Server_LastHeartbeat");

                entity.Property(e => e.Id).HasMaxLength(100);

                entity.Property(e => e.LastHeartbeat).HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiceCode>(entity =>
            {
                entity.ToTable("ServiceCode");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(16);

                entity.Property(e => e.Color).HasMaxLength(6);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ServiceCodes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceCode_Company");
            });

            modelBuilder.Entity<ServiceCodeProduct>(entity =>
            {
                entity.ToTable("ServiceCodeProduct");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.ProductId).HasColumnName("ProductID");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ServiceCodeProducts)
                    .HasForeignKey(d => d.CustomerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceCodeProduct_Customer");

                entity.HasOne(d => d.Product)
                    .WithMany(p => p.ServiceCodeProducts)
                    .HasForeignKey(d => d.ProductId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceCodeProduct_Product");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.ServiceCodeProducts)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceCodeProduct_ServiceCode");
            });

            modelBuilder.Entity<ServiceLane>(entity =>
            {
                entity.ToTable("ServiceLane");

                entity.HasIndex(e => e.CompanyId, "NC_CompanyID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.CustomerId, "NC_CustomerID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.FromPricingZone, "NC_FromPricingZone")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.PricingScheduleId, "NC_PricingScheduleID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ServiceCodeId, "NC_ServiceCodeID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ServiceLaneStatusId, "NC_ServiceLaneStatusID")
                    .HasFillFactor(90);

                entity.HasIndex(e => e.ToPricingZone, "NC_ToPricingZone")
                    .HasFillFactor(90);

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.MinCharge).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Name).HasMaxLength(500);

                entity.Property(e => e.PricingScheduleId).HasColumnName("PricingScheduleID");

                entity.Property(e => e.ServiceCodeId).HasColumnName("ServiceCodeID");

                entity.Property(e => e.ServiceLaneStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("ServiceLaneStatusID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.ServiceLanes)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLane_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.ServiceLanes)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_ServiceLane_Customer");

                entity.HasOne(d => d.FromPricingZoneNavigation)
                    .WithMany(p => p.ServiceLaneFromPricingZoneNavigations)
                    .HasForeignKey(d => d.FromPricingZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLane_Zone");

                entity.HasOne(d => d.PricingSchedule)
                    .WithMany(p => p.ServiceLanes)
                    .HasForeignKey(d => d.PricingScheduleId)
                    .HasConstraintName("FK_ServiceLane_PricingSchedule");

                entity.HasOne(d => d.ServiceCode)
                    .WithMany(p => p.ServiceLanes)
                    .HasForeignKey(d => d.ServiceCodeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLane_ServiceCode");

                entity.HasOne(d => d.ServiceLaneStatus)
                    .WithMany(p => p.ServiceLanes)
                    .HasForeignKey(d => d.ServiceLaneStatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLane_ServiceLaneStatus");

                entity.HasOne(d => d.ToPricingZoneNavigation)
                    .WithMany(p => p.ServiceLaneToPricingZoneNavigations)
                    .HasForeignKey(d => d.ToPricingZone)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ServiceLane_Zone1");
            });

            modelBuilder.Entity<ServiceLaneStatus>(entity =>
            {
                entity.ToTable("ServiceLaneStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Set>(entity =>
            {
                entity.HasKey(e => new { e.Key, e.Value })
                    .HasName("PK_HangFire_Set");

                entity.ToTable("Set", "HangFire");

                entity.HasIndex(e => e.ExpireAt, "IX_HangFire_Set_ExpireAt")
                    .HasFilter("([ExpireAt] IS NOT NULL)");

                entity.HasIndex(e => new { e.Key, e.Score }, "IX_HangFire_Set_Score");

                entity.Property(e => e.Key).HasMaxLength(100);

                entity.Property(e => e.Value).HasMaxLength(256);

                entity.Property(e => e.ExpireAt).HasColumnType("datetime");
            });

            modelBuilder.Entity<Smsqueue>(entity =>
            {
                entity.ToTable("SMSQueue");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.LastAttempt).HasColumnType("datetime");

                entity.Property(e => e.Smsbody)
                    .HasMaxLength(200)
                    .HasColumnName("SMSBody");

                entity.Property(e => e.Smsid)
                    .HasMaxLength(200)
                    .HasColumnName("SMSID");

                entity.Property(e => e.Smsto)
                    .HasMaxLength(50)
                    .HasColumnName("SMSTo");

                entity.Property(e => e.TimeStamp).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Smsqueues)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SMSQueue_Company");
            });

            modelBuilder.Entity<Spabatch>(entity =>
            {
                entity.ToTable("SPABatch");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasMaxLength(50)
                    .HasColumnName("UserID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Spabatches)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPABatch_Company");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Spabatches)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SPABatch_WebPanelUser");
            });

            modelBuilder.Entity<SplitExpenseRule>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SplitPriceRule>(entity =>
            {
                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<State>(entity =>
            {
                entity.ToTable("State");

                entity.Property(e => e.Id)
                    .HasMaxLength(10)
                    .HasColumnName("ID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.States)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_State_Country");
            });

            modelBuilder.Entity<State1>(entity =>
            {
                entity.HasKey(e => new { e.JobId, e.Id })
                    .HasName("PK_HangFire_State");

                entity.ToTable("State", "HangFire");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(20);

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.HasOne(d => d.Job)
                    .WithMany(p => p.State1s)
                    .HasForeignKey(d => d.JobId)
                    .HasConstraintName("FK_HangFire_State_Job");
            });

            modelBuilder.Entity<Subcontractor>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Abn)
                    .HasMaxLength(20)
                    .HasColumnName("ABN");

                entity.Property(e => e.AccountingSystemId).HasColumnName("AccountingSystemID");

                entity.Property(e => e.AccoutingSystemInstanceId).HasColumnName("AccoutingSystemInstanceID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.CompanyId)
                    .HasColumnName("CompanyID")
                    .HasDefaultValueSql("(newid())");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Gstregistered).HasColumnName("GSTRegistered");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PaymentTermsEop).HasColumnName("PaymentTermsEOP");

                entity.Property(e => e.PaymentTermsId)
                    .HasMaxLength(10)
                    .HasColumnName("PaymentTermsID");

                entity.Property(e => e.PostalLocationId).HasColumnName("PostalLocationID");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Username).HasMaxLength(50);

                entity.HasOne(d => d.AccoutingSystemInstance)
                    .WithMany(p => p.Subcontractors)
                    .HasForeignKey(d => d.AccoutingSystemInstanceId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_Subcontractor_AccountingSystemInstance");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Subcontractors)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subcontractors_Company");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Subcontractors)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Subcontractors_Country");

                entity.HasOne(d => d.PaymentTerms)
                    .WithMany(p => p.Subcontractors)
                    .HasForeignKey(d => d.PaymentTermsId)
                    .HasConstraintName("FK_Subcontractor_PaymentTerms");

                entity.HasOne(d => d.PostalLocation)
                    .WithMany(p => p.Subcontractors)
                    .HasForeignKey(d => d.PostalLocationId)
                    .HasConstraintName("FK_Subcontractors_Location");
            });

            modelBuilder.Entity<SubcontractorLocationZone>(entity =>
            {
                entity.ToTable("SubcontractorLocationZone");

                entity.HasIndex(e => e.SubcontractorId, "IX_SubcontractorIDlist");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.SubcontractorLocationZones)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_SubcontractorLocationZone_Location");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.SubcontractorLocationZones)
                    .HasForeignKey(d => d.SubcontractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubcontractorLocationZone_Subcontractors");

                entity.HasOne(d => d.Suburb)
                    .WithMany(p => p.SubcontractorLocationZones)
                    .HasForeignKey(d => d.SuburbId)
                    .HasConstraintName("FK_SubcontractorLocationZone_Suburbs");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.SubcontractorLocationZones)
                    .HasForeignKey(d => d.ZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubcontractorLocationZone_Zone");
            });

            modelBuilder.Entity<SubcontractorPayment>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.GrossAmount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobLegId).HasColumnName("JobLegID");

                entity.Property(e => e.PaymentNumber).HasMaxLength(50);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.SubcontractorPaymentStatusId).HasColumnName("SubcontractorPaymentStatusID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.JobLeg)
                    .WithMany(p => p.SubcontractorPayments)
                    .HasForeignKey(d => d.JobLegId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_SubcontractorPayment_JobLeg");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.SubcontractorPayments)
                    .HasForeignKey(d => d.SubcontractorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SubcontractorPayment_Subcontractor");

                entity.HasOne(d => d.SubcontractorPaymentStatus)
                    .WithMany(p => p.SubcontractorPayments)
                    .HasForeignKey(d => d.SubcontractorPaymentStatusId)
                    .HasConstraintName("FK_SubcontractorPayment_SubcontractorPaymentStatus");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SubcontractorPayments)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_SubcontractorPayment_UserID");
            });

            modelBuilder.Entity<SubcontractorPaymentStatus>(entity =>
            {
                entity.ToTable("SubcontractorPaymentStatus");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<SubcontractorStaff>(entity =>
            {
                entity.ToTable("SubcontractorStaff");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.Telephone).HasMaxLength(50);

                entity.Property(e => e.Username).HasMaxLength(50);
            });

            modelBuilder.Entity<Suburb>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostingZoneId).HasColumnName("CostingZoneID");

                entity.Property(e => e.DepotZoneId).HasColumnName("DepotZoneID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PricingZoneId).HasColumnName("PricingZoneID");

                entity.Property(e => e.StateId)
                    .HasMaxLength(10)
                    .HasColumnName("StateID");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Suburbs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_Suburbs_Company");

                entity.HasOne(d => d.CostingZone)
                    .WithMany(p => p.SuburbCostingZones)
                    .HasForeignKey(d => d.CostingZoneId)
                    .HasConstraintName("FK_CostingZoneID");

                entity.HasOne(d => d.DepotZone)
                    .WithMany(p => p.SuburbDepotZones)
                    .HasForeignKey(d => d.DepotZoneId)
                    .HasConstraintName("FK_DepotZoneID");

                entity.HasOne(d => d.PricingZone)
                    .WithMany(p => p.SuburbPricingZones)
                    .HasForeignKey(d => d.PricingZoneId)
                    .HasConstraintName("FK_PricingZoneID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Suburbs)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Suburbs_State");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.SuburbZones)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("FK_Suburbs_Zone");
            });

            modelBuilder.Entity<SuburbDistanceConfig>(entity =>
            {
                entity.ToTable("SuburbDistanceConfig");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Kilometers).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NameFrom).HasMaxLength(50);

                entity.Property(e => e.NameTo).HasMaxLength(50);

                entity.Property(e => e.StateIdfrom)
                    .HasMaxLength(10)
                    .HasColumnName("StateIDFrom");

                entity.Property(e => e.StateIdto)
                    .HasMaxLength(10)
                    .HasColumnName("StateIDTo");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.SuburbDistanceConfigs)
                    .HasForeignKey(d => d.CompanyId)
                    .HasConstraintName("FK_SuburbDistanceConfig_Company");
            });

            modelBuilder.Entity<SuburbDistanceConfigView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("SuburbDistanceConfigView");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.From).HasMaxLength(74);

                entity.Property(e => e.Hours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Kilometers).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.NameFrom).HasMaxLength(50);

                entity.Property(e => e.NameTo).HasMaxLength(50);

                entity.Property(e => e.StateIdfrom)
                    .HasMaxLength(10)
                    .HasColumnName("StateIDFrom");

                entity.Property(e => e.StateIdto)
                    .HasMaxLength(10)
                    .HasColumnName("StateIDTo");

                entity.Property(e => e.To).HasMaxLength(74);
            });

            modelBuilder.Entity<SystemEventLog>(entity =>
            {
                entity.ToTable("SystemEventLog");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Source).HasMaxLength(100);

                entity.Property(e => e.Timestamp).HasColumnType("datetime");
            });

            modelBuilder.Entity<SystemPermission>(entity =>
            {
                entity.ToTable("SystemPermission");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.SystemSectionId).HasColumnName("SystemSectionID");

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.HasOne(d => d.SystemSection)
                    .WithMany(p => p.SystemPermissions)
                    .HasForeignKey(d => d.SystemSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemPermission_SystemPermission");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.SystemPermissions)
                    .HasForeignKey(d => d.UserGroupId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemPermission_UserGroup");
            });

            modelBuilder.Entity<SystemSection>(entity =>
            {
                entity.ToTable("SystemSection");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SectionGroup).HasMaxLength(255);
            });

            modelBuilder.Entity<SystemSectionUserType>(entity =>
            {
                entity.ToTable("SystemSectionUserType");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SystemSectionId).HasColumnName("SystemSectionID");

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.SystemSection)
                    .WithMany(p => p.SystemSectionUserTypes)
                    .HasForeignKey(d => d.SystemSectionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemSectionUserType_SystemSection");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.SystemSectionUserTypes)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SystemSectionUserType_WebPanelUsersType");
            });

            modelBuilder.Entity<TempLocation>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempLocation");

                entity.Property(e => e.Address1)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS_1");

                entity.Property(e => e.Address2)
                    .HasMaxLength(255)
                    .HasColumnName("ADDRESS_2");

                entity.Property(e => e.Code).HasMaxLength(255);

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("NAME");

                entity.Property(e => e.Phone).HasMaxLength(255);

                entity.Property(e => e.PostalCode).HasColumnName("POSTAL_CODE");

                entity.Property(e => e.State).HasMaxLength(255);

                entity.Property(e => e.Suburb).HasMaxLength(255);

                entity.Property(e => e.Zone).HasMaxLength(255);
            });

            modelBuilder.Entity<TempMarleysProductsImport>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TempMarleysProductsImport");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Group).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<TimeSlot>(entity =>
            {
                entity.ToTable("TimeSlot");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TimeSlots)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeSlot_Company");
            });

            modelBuilder.Entity<Tmsapi>(entity =>
            {
                entity.HasKey(e => e.AuthToken);

                entity.ToTable("TMSAPI");

                entity.Property(e => e.AuthToken).ValueGeneratedNever();

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ServerUrl)
                    .HasMaxLength(200)
                    .HasColumnName("ServerURL")
                    .HasDefaultValueSql("(N' ')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Tmsapis)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TMSAPI_Company");
            });

            modelBuilder.Entity<TrailerConfiguration>(entity =>
            {
                entity.ToTable("TrailerConfiguration");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Code).HasMaxLength(4);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TransactionTable>(entity =>
            {
                entity.ToTable("TransactionTable");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AccountName).HasMaxLength(100);

                entity.Property(e => e.Amount).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Credit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Debit).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.DefaultAccountId).HasColumnName("DefaultAccountID");

                entity.Property(e => e.Description).HasMaxLength(500);

                entity.Property(e => e.ObjectId).HasColumnName("ObjectID");

                entity.Property(e => e.Reference).HasMaxLength(100);

                entity.Property(e => e.TransactionDate).HasColumnType("datetime");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.TransactionTables)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TransactionTable_Company");
            });

            modelBuilder.Entity<TripEnquiryView>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TripEnquiryView");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.Contact).HasMaxLength(500);

                entity.Property(e => e.Customer).HasMaxLength(200);

                entity.Property(e => e.CustomerEntity)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DriverId).HasColumnName("DriverID");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.JobBookingType).HasMaxLength(10);

                entity.Property(e => e.JobCubicWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobDate).HasColumnType("datetime");

                entity.Property(e => e.JobDateEntered).HasColumnType("datetime");

                entity.Property(e => e.JobDepot).HasMaxLength(100);

                entity.Property(e => e.JobEnteredBy).HasMaxLength(50);

                entity.Property(e => e.JobHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobId).HasColumnName("JobID");

                entity.Property(e => e.JobKms).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobNumber).HasMaxLength(50);

                entity.Property(e => e.JobPallets).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobPriceStatus).HasMaxLength(50);

                entity.Property(e => e.JobPriceStatusColor).HasMaxLength(50);

                entity.Property(e => e.JobPriceStatusId)
                    .HasMaxLength(10)
                    .HasColumnName("JobPriceStatusID");

                entity.Property(e => e.JobProductOwner).HasMaxLength(200);

                entity.Property(e => e.JobQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobReady).HasColumnType("datetime");

                entity.Property(e => e.JobReadyDate).HasColumnType("datetime");

                entity.Property(e => e.JobReadyFromCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobRequired).HasColumnType("datetime");

                entity.Property(e => e.JobRequiredCustomOffset).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobService).HasMaxLength(100);

                entity.Property(e => e.JobSpace).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobStatus).HasMaxLength(50);

                entity.Property(e => e.JobStatusColor).HasMaxLength(20);

                entity.Property(e => e.JobStatusId)
                    .HasMaxLength(3)
                    .HasColumnName("JobStatusID");

                entity.Property(e => e.JobWaiting).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobWeight).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.JobWeightType).HasMaxLength(10);

                entity.Property(e => e.LegCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegCostingStatus).HasMaxLength(50);

                entity.Property(e => e.LegCostingStatusColor).HasMaxLength(50);

                entity.Property(e => e.LegCostingStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("LegCostingStatusID");

                entity.Property(e => e.LegDate).HasColumnType("datetime");

                entity.Property(e => e.LegDepot).HasMaxLength(100);

                entity.Property(e => e.LegDriver).HasMaxLength(500);

                entity.Property(e => e.LegDriverType).HasMaxLength(50);

                entity.Property(e => e.LegDriverTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("LegDriverTypeID");

                entity.Property(e => e.LegExpense).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegFromAllocationZone).HasMaxLength(200);

                entity.Property(e => e.LegFromCostingZone).HasMaxLength(200);

                entity.Property(e => e.LegFromId).HasColumnName("LegFromID");

                entity.Property(e => e.LegFromName).HasMaxLength(100);

                entity.Property(e => e.LegFromPostcode).HasMaxLength(10);

                entity.Property(e => e.LegFromState).HasMaxLength(10);

                entity.Property(e => e.LegFromSuburb).HasMaxLength(50);

                entity.Property(e => e.LegHours).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegKilometers).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegManifest).HasMaxLength(50);

                entity.Property(e => e.LegManifestId).HasColumnName("LegManifestID");

                entity.Property(e => e.LegNettCost).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegNumber).HasMaxLength(65);

                entity.Property(e => e.LegProfit).HasColumnType("decimal(20, 2)");

                entity.Property(e => e.LegProfitPerKilometer).HasColumnType("decimal(38, 18)");

                entity.Property(e => e.LegProfitPercentage).HasColumnType("numeric(38, 14)");

                entity.Property(e => e.LegQuantity).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegRevenue).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.LegService).HasMaxLength(100);

                entity.Property(e => e.LegStatus).HasMaxLength(50);

                entity.Property(e => e.LegStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("LegStatusID");

                entity.Property(e => e.LegToAllocationZone).HasMaxLength(200);

                entity.Property(e => e.LegToCostingZone).HasMaxLength(200);

                entity.Property(e => e.LegToId).HasColumnName("LegToID");

                entity.Property(e => e.LegToName).HasMaxLength(100);

                entity.Property(e => e.LegToPostcode).HasMaxLength(10);

                entity.Property(e => e.LegToState).HasMaxLength(10);

                entity.Property(e => e.LegToSuburb).HasMaxLength(50);

                entity.Property(e => e.LegTrailer1).HasMaxLength(8);

                entity.Property(e => e.LegTrailer1Id).HasColumnName("LegTrailer1ID");

                entity.Property(e => e.LegTrailer2).HasMaxLength(8);

                entity.Property(e => e.LegTrailer2Id).HasColumnName("LegTrailer2ID");

                entity.Property(e => e.LegTrailer3).HasMaxLength(8);

                entity.Property(e => e.LegTrailer3Id).HasColumnName("LegTrailer3ID");

                entity.Property(e => e.LegTripStatus).HasMaxLength(50);

                entity.Property(e => e.LegTripStatusColor).HasMaxLength(20);

                entity.Property(e => e.LegTripStatusId)
                    .HasMaxLength(5)
                    .HasColumnName("LegTripStatusID");

                entity.Property(e => e.LegType).HasMaxLength(50);

                entity.Property(e => e.LegVehicle).HasMaxLength(8);

                entity.Property(e => e.LegVehicleId).HasColumnName("LegVehicleID");

                entity.Property(e => e.ManifestName).HasMaxLength(200);

                entity.Property(e => e.PodexceptionId)
                    .HasMaxLength(5)
                    .HasColumnName("PODExceptionID");

                entity.Property(e => e.PodexceptionNote).HasColumnName("PODExceptionNote");

                entity.Property(e => e.PodreceiverAppNote)
                    .HasMaxLength(200)
                    .HasColumnName("PODReceiverAppNote");

                entity.Property(e => e.PodsignatureTimestamp)
                    .HasColumnType("datetime")
                    .HasColumnName("PODSignatureTimestamp");

                entity.Property(e => e.PodsignedBy)
                    .HasMaxLength(50)
                    .HasColumnName("PODSignedBy");

                entity.Property(e => e.Podstatus)
                    .HasMaxLength(5)
                    .HasColumnName("PODStatus");

                entity.Property(e => e.ReceiverArrive).HasColumnType("datetime");

                entity.Property(e => e.ReceiverDepart).HasColumnType("datetime");

                entity.Property(e => e.ReceiverId).HasColumnName("ReceiverID");

                entity.Property(e => e.ReceiverLocation).HasMaxLength(500);

                entity.Property(e => e.ReceiverName).HasMaxLength(100);

                entity.Property(e => e.ReceiverPhone).HasMaxLength(50);

                entity.Property(e => e.ReceiverPostcode).HasMaxLength(10);

                entity.Property(e => e.ReceiverState).HasMaxLength(10);

                entity.Property(e => e.Reference1).HasMaxLength(200);

                entity.Property(e => e.Reference10).HasMaxLength(200);

                entity.Property(e => e.Reference2).HasMaxLength(200);

                entity.Property(e => e.Reference3).HasMaxLength(200);

                entity.Property(e => e.Reference4).HasMaxLength(200);

                entity.Property(e => e.Reference5).HasMaxLength(200);

                entity.Property(e => e.Reference6).HasMaxLength(200);

                entity.Property(e => e.Reference7).HasMaxLength(200);

                entity.Property(e => e.Reference8).HasMaxLength(200);

                entity.Property(e => e.Reference9).HasMaxLength(200);

                entity.Property(e => e.SenderArrive).HasColumnType("datetime");

                entity.Property(e => e.SenderDepart).HasColumnType("datetime");

                entity.Property(e => e.SenderId).HasColumnName("SenderID");

                entity.Property(e => e.SenderLocation).HasMaxLength(500);

                entity.Property(e => e.SenderName).HasMaxLength(100);

                entity.Property(e => e.SenderPhone).HasMaxLength(50);

                entity.Property(e => e.SenderPostcode).HasMaxLength(10);
            });

            modelBuilder.Entity<TripStatus>(entity =>
            {
                entity.ToTable("TripStatus");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Color).HasMaxLength(20);

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("User");

                entity.HasIndex(e => e.FullName, "IX_UserFullName_ASC");

                entity.HasIndex(e => e.FullName, "IX_UserFullName_DESC");

                entity.HasIndex(e => new { e.Id, e.UserTypeId }, "_dta_index_User_5_761769771__K1_K10_2_3");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AllocationZoneId).HasColumnName("AllocationZoneID");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CostGroupId).HasColumnName("CostGroupID");

                entity.Property(e => e.CountryId)
                    .HasColumnName("CountryID")
                    .HasDefaultValueSql("((9))");

                entity.Property(e => e.DefaultTrailer1Id).HasColumnName("DefaultTrailer1ID");

                entity.Property(e => e.DefaultTrailer2Id).HasColumnName("DefaultTrailer2ID");

                entity.Property(e => e.DefaultVehicleId).HasColumnName("DefaultVehicleID");

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.DispatchViaSms).HasColumnName("DispatchViaSMS");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.FleetConfigurationId).HasColumnName("FleetConfigurationID");

                entity.Property(e => e.FullName).HasMaxLength(500);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.Phone).HasMaxLength(50);

                entity.Property(e => e.Pincode).HasColumnName("PINCode");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.UserTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("UserTypeID")
                    .HasDefaultValueSql("(N'DRVR')");

                entity.Property(e => e.UserWebapp).HasColumnName("UserWEBApp");

                entity.Property(e => e.UsesPodapp)
                    .IsRequired()
                    .HasColumnName("UsesPODApp")
                    .HasDefaultValueSql("((1))");

                entity.HasOne(d => d.AllocationZone)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.AllocationZoneId)
                    .HasConstraintName("FK_User_Zone");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Company");

                entity.HasOne(d => d.CostGroup)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CostGroupId)
                    .HasConstraintName("FK_CostGroupUserID");

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.CountryId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_Country");

                entity.HasOne(d => d.DefaultTrailer1)
                    .WithMany(p => p.UserDefaultTrailer1s)
                    .HasForeignKey(d => d.DefaultTrailer1Id)
                    .HasConstraintName("FK_User_Vehicle1");

                entity.HasOne(d => d.DefaultTrailer2)
                    .WithMany(p => p.UserDefaultTrailer2s)
                    .HasForeignKey(d => d.DefaultTrailer2Id)
                    .HasConstraintName("FK_User_Vehicle2");

                entity.HasOne(d => d.DefaultVehicle)
                    .WithMany(p => p.UserDefaultVehicles)
                    .HasForeignKey(d => d.DefaultVehicleId)
                    .HasConstraintName("FK_User_Vehicle");

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_User_Location");

                entity.HasOne(d => d.FleetConfiguration)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.FleetConfigurationId)
                    .HasConstraintName("FK_User_FleetConfiguration");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.SubcontractorId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_User_Subcontractor");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_User_UserType");
            });

            modelBuilder.Entity<UserGroup>(entity =>
            {
                entity.ToTable("UserGroup");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.ModifiedOn).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.UserTypeId).HasColumnName("UserTypeID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroup_Company");

                entity.HasOne(d => d.UserType)
                    .WithMany(p => p.UserGroups)
                    .HasForeignKey(d => d.UserTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserGroup_WebPanelUsersType");
            });

            modelBuilder.Entity<UserType>(entity =>
            {
                entity.ToTable("UserType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Vehicle>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(20);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.JobCodeId).HasColumnName("JobCodeID");

                entity.Property(e => e.LocationId).HasColumnName("LocationID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.RegistrationNumber).HasMaxLength(50);

                entity.Property(e => e.VehicleTypeId)
                    .HasMaxLength(5)
                    .HasColumnName("VehicleTypeID")
                    .HasDefaultValueSql("(N'RGLR')");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_Company");

                entity.HasOne(d => d.JobCode)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.JobCodeId)
                    .HasConstraintName("FK_Vehicle_JobCode");

                entity.HasOne(d => d.Location)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.LocationId)
                    .HasConstraintName("FK_Vehicle_Location");

                entity.HasOne(d => d.VehicleType)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.VehicleTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Vehicle_VehicleType");
            });

            modelBuilder.Entity<VehicleType>(entity =>
            {
                entity.ToTable("VehicleType");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<ViewTemplate>(entity =>
            {
                entity.ToTable("ViewTemplate");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.ViewRoute).HasMaxLength(500);

                entity.Property(e => e.ViewRoute1).HasMaxLength(500);

                entity.Property(e => e.ViewType).HasMaxLength(50);
            });

            modelBuilder.Entity<VwAspnetApplication>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Applications");

                entity.Property(e => e.ApplicationName).HasMaxLength(256);

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredApplicationName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetMembershipUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_MembershipUsers");

                entity.Property(e => e.Comment).HasColumnType("ntext");

                entity.Property(e => e.CreateDate).HasColumnType("datetime");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.FailedPasswordAnswerAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.FailedPasswordAttemptWindowStart).HasColumnType("datetime");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LastLockoutDate).HasColumnType("datetime");

                entity.Property(e => e.LastLoginDate).HasColumnType("datetime");

                entity.Property(e => e.LastPasswordChangedDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredEmail).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.MobilePin)
                    .HasMaxLength(16)
                    .HasColumnName("MobilePIN");

                entity.Property(e => e.PasswordAnswer).HasMaxLength(128);

                entity.Property(e => e.PasswordQuestion).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetProfile>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Profiles");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Roles");

                entity.Property(e => e.Description).HasMaxLength(256);

                entity.Property(e => e.LoweredRoleName).HasMaxLength(256);

                entity.Property(e => e.RoleName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_Users");

                entity.Property(e => e.LastActivityDate).HasColumnType("datetime");

                entity.Property(e => e.LoweredUserName).HasMaxLength(256);

                entity.Property(e => e.MobileAlias).HasMaxLength(16);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetUsersInRole>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_UsersInRoles");
            });

            modelBuilder.Entity<VwAspnetWebPartStatePath>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Paths");

                entity.Property(e => e.LoweredPath).HasMaxLength(256);

                entity.Property(e => e.Path).HasMaxLength(256);
            });

            modelBuilder.Entity<VwAspnetWebPartStateShared>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_Shared");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<VwAspnetWebPartStateUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("vw_aspnet_WebPartState_User");

                entity.Property(e => e.LastUpdatedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<WebPanelUser>(entity =>
            {
                entity.ToTable("WebPanelUser");

                entity.Property(e => e.Id)
                    .HasMaxLength(50)
                    .HasColumnName("ID");

                entity.Property(e => e.Address).HasMaxLength(200);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.DepotId).HasColumnName("DepotID");

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.LastName).HasMaxLength(100);

                entity.Property(e => e.ReceiveSummaryEmail)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.Telephone1).HasMaxLength(50);

                entity.Property(e => e.Telephone2).HasMaxLength(50);

                entity.Property(e => e.UserGroupId).HasColumnName("UserGroupID");

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.WebPanelUsers)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebPanelUser_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WebPanelUsers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_WebPanelUser_Customer");

                entity.HasOne(d => d.Depot)
                    .WithMany(p => p.WebPanelUsers)
                    .HasForeignKey(d => d.DepotId)
                    .HasConstraintName("FK_WebPanelUser_Location");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.WebPanelUsers)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_WebPanelUser_Subcontractors");

                entity.HasOne(d => d.TypeNavigation)
                    .WithMany(p => p.WebPanelUsers)
                    .HasForeignKey(d => d.Type)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WebPanelUser_WebPanelUsersType");

                entity.HasOne(d => d.UserGroup)
                    .WithMany(p => p.WebPanelUsers)
                    .HasForeignKey(d => d.UserGroupId)
                    .HasConstraintName("FK_WebPanelUser_UserGroup");
            });

            modelBuilder.Entity<WebPanelUserCustomer>(entity =>
            {
                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.WebPanelUserId)
                    .HasMaxLength(50)
                    .HasColumnName("WebPanelUserID");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.WebPanelUserCustomers)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK__WebPanelU__Custo__799DF262");

                entity.HasOne(d => d.WebPanelUser)
                    .WithMany(p => p.WebPanelUserCustomers)
                    .HasForeignKey(d => d.WebPanelUserId)
                    .HasConstraintName("FK__WebPanelU__WebPa__78A9CE29");
            });

            modelBuilder.Entity<WebPanelUsersType>(entity =>
            {
                entity.ToTable("WebPanelUsersType");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkflowKind>(entity =>
            {
                entity.ToTable("WorkflowKind");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<WorkflowSubKind>(entity =>
            {
                entity.ToTable("WorkflowSubKind");

                entity.Property(e => e.Id)
                    .HasMaxLength(5)
                    .HasColumnName("ID");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<Zone>(entity =>
            {
                entity.ToTable("Zone");

                entity.HasIndex(e => e.Id, "_dta_index_Zone_5_1432392172__K1_6");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Active)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.CustomerId).HasColumnName("CustomerID");

                entity.Property(e => e.Group1Id).HasColumnName("Group1ID");

                entity.Property(e => e.Group2Id).HasColumnName("Group2ID");

                entity.Property(e => e.ModifiedBy).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.SubcontractorId).HasColumnName("SubcontractorID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.ZoneTypeId)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ZoneTypeID")
                    .IsFixedLength();

                entity.HasOne(d => d.Company)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.CompanyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zone_Company");

                entity.HasOne(d => d.Customer)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.CustomerId)
                    .HasConstraintName("FK_Zone_Customer");

                entity.HasOne(d => d.Group1)
                    .WithMany(p => p.ZoneGroup1s)
                    .HasForeignKey(d => d.Group1Id)
                    .HasConstraintName("FK_Zone_Group1");

                entity.HasOne(d => d.Group2)
                    .WithMany(p => p.ZoneGroup2s)
                    .HasForeignKey(d => d.Group2Id)
                    .HasConstraintName("FK_Zone_Group2");

                entity.HasOne(d => d.ModifiedByNavigation)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.ModifiedBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zone_WebPanelUser");

                entity.HasOne(d => d.Subcontractor)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.SubcontractorId)
                    .HasConstraintName("FK_Zone_Subcontractors");

                entity.HasOne(d => d.ZoneType)
                    .WithMany(p => p.Zones)
                    .HasForeignKey(d => d.ZoneTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Zone_ZoneType");
            });

            modelBuilder.Entity<ZoneType>(entity =>
            {
                entity.ToTable("ZoneType");

                entity.Property(e => e.Id)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasColumnName("ID")
                    .IsFixedLength();

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<ZonesMulti>(entity =>
            {
                entity.ToTable("ZonesMulti");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CompanyId).HasColumnName("CompanyID");

                entity.Property(e => e.SuburbId).HasColumnName("SuburbID");

                entity.Property(e => e.Timestamp).HasColumnType("datetime");

                entity.Property(e => e.ZoneId).HasColumnName("ZoneID");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.ZonesMultis)
                    .HasForeignKey(d => d.ZoneId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ZonesMulti_Zone");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
