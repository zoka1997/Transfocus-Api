using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Company
    {
        public Company()
        {
            AccountingSystemInstances = new HashSet<AccountingSystemInstance>();
            Activities = new HashSet<Activity>();
            Apikeys = new HashSet<Apikey>();
            AutomaticEdilogs = new HashSet<AutomaticEdilog>();
            CheckLists = new HashSet<CheckList>();
            CompanyCompliances = new HashSet<CompanyCompliance>();
            CompanyHistories = new HashSet<CompanyHistory>();
            CompanyTolls = new HashSet<CompanyToll>();
            Compliances = new HashSet<Compliance>();
            ConsolidatedConsignmentNotes = new HashSet<ConsolidatedConsignmentNote>();
            Contacts = new HashSet<Contact>();
            CostingSchedules = new HashSet<CostingSchedule>();
            CreditNoteSalesLedgers = new HashSet<CreditNoteSalesLedger>();
            CubicWeightConversionRates = new HashSet<CubicWeightConversionRate>();
            CustomActivityProducts = new HashSet<CustomActivityProduct>();
            CustomPages = new HashSet<CustomPage>();
            CustomerLocations = new HashSet<CustomerLocation>();
            Customers = new HashSet<Customer>();
            DeviceCrashLogs = new HashSet<DeviceCrashLog>();
            Edilogs = new HashSet<Edilog>();
            EmailQueues = new HashSet<EmailQueue>();
            FleetAssets = new HashSet<FleetAsset>();
            FleetRunningCosts = new HashSet<FleetRunningCost>();
            FoxProSyncDates = new HashSet<FoxProSyncDate>();
            GenericGroups = new HashSet<GenericGroup>();
            GlobalAlerts = new HashSet<GlobalAlert>();
            GridStateProfiles = new HashSet<GridStateProfile>();
            InvoiceBatches = new HashSet<InvoiceBatch>();
            Invoices = new HashSet<Invoice>();
            JobCancelReasons = new HashSet<JobCancelReason>();
            JobCodes = new HashSet<JobCode>();
            JobDocumentTypes = new HashSet<JobDocumentType>();
            JobImportModes = new HashSet<JobImportMode>();
            JobSenderRecipientDefaults = new HashSet<JobSenderRecipientDefault>();
            Jobs = new HashSet<Job>();
            Locations = new HashSet<Location>();
            ManifestNames = new HashSet<ManifestName>();
            Manifests = new HashSet<Manifest>();
            MobileDevices = new HashSet<MobileDevice>();
            PalletAccounts = new HashSet<PalletAccount>();
            PanelInvoices = new HashSet<PanelInvoice>();
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
            PricingScheduleTypes = new HashSet<PricingScheduleType>();
            PricingSchedules = new HashSet<PricingSchedule>();
            Pricings = new HashSet<Pricing>();
            ProductLocations = new HashSet<ProductLocation>();
            Products = new HashSet<Product>();
            PublicHolidays = new HashSet<PublicHoliday>();
            RecurrenceJobSchedules = new HashSet<RecurrenceJobSchedule>();
            ReferenceTypes = new HashSet<ReferenceType>();
            ReportCompanyLists = new HashSet<ReportCompanyList>();
            ServiceCodes = new HashSet<ServiceCode>();
            ServiceLanes = new HashSet<ServiceLane>();
            Smsqueues = new HashSet<Smsqueue>();
            Spabatches = new HashSet<Spabatch>();
            Subcontractors = new HashSet<Subcontractor>();
            SuburbDistanceConfigs = new HashSet<SuburbDistanceConfig>();
            Suburbs = new HashSet<Suburb>();
            TimeSlots = new HashSet<TimeSlot>();
            Tmsapis = new HashSet<Tmsapi>();
            TransactionTables = new HashSet<TransactionTable>();
            UserGroups = new HashSet<UserGroup>();
            Users = new HashSet<User>();
            Vehicles = new HashSet<Vehicle>();
            WebPanelUsers = new HashSet<WebPanelUser>();
            Zones = new HashSet<Zone>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string WebServiceUrl { get; set; } = null!;
        public int WebServiceTimeout { get; set; }
        public int PhotoSize { get; set; }
        public int Gpsfrequency { get; set; }
        public int Version { get; set; }
        public int GpssendFrequency { get; set; }
        public bool? ConsignmentsEnabled { get; set; }
        public bool PickupsEnabled { get; set; }
        public bool? CouriersEnabled { get; set; }
        public bool? LinehaulsEnabled { get; set; }
        public bool RequestConsigmentsAcknowledgement { get; set; }
        public bool RequestPickupsAcknowledgement { get; set; }
        public bool? RequestCouriersAcknowledgement { get; set; }
        public bool? RequestLinehaulsAcknowledgement { get; set; }
        public bool RequestMessagesAcknowledgement { get; set; }
        public int AdminPin { get; set; }
        public string? Tmsurl { get; set; }
        public string? FoxProUrl { get; set; }
        public Guid? Tmstoken { get; set; }
        public Guid? FoxProToken { get; set; }
        public bool? IsTms { get; set; }
        public int ForceLogoutTimeout { get; set; }
        public bool? UseModernDateTimePicker { get; set; }
        public int BackupSyncFrequency { get; set; }
        public string? JobNumberPrefix { get; set; }
        public long JobNumberStartIndex { get; set; }
        public long? JobNumberLastIndex { get; set; }
        public bool? DeliverySignatureAtArrivedSenderCustomer { get; set; }
        public bool? DeliverySignatureAtArrivedSenderDepot { get; set; }
        public bool? DeliverySignatureAtArrivedReceiverCustomer { get; set; }
        public bool? DeliverySignatureAtArrivedReceiverDepot { get; set; }
        public bool? DeliveryWaitingTimeAtSenderCustomer { get; set; }
        public bool? DeliveryWaitingTimeAtSenderDepot { get; set; }
        public bool? DeliveryWaitingTimeAtReceiverCustomer { get; set; }
        public bool? DeliveryWaitingTimeAtReceiverDepot { get; set; }
        public bool? DeliveryTimestampsAtSenderCustomer { get; set; }
        public bool? DeliveryTimestampsAtSenderDepot { get; set; }
        public bool? DeliveryTimestampsAtReceiverCustomer { get; set; }
        public bool? DeliveryTimestampsAtReceiverDepot { get; set; }
        public bool? DeliveryScanAtSenderCustomer { get; set; }
        public bool? DeliveryScanAtSenderDepot { get; set; }
        public bool? DeliveryScanAtReceiverCustomer { get; set; }
        public bool? DeliveryScanAtReceiverDepot { get; set; }
        public bool? PickupSignatureAtArrivedSenderCustomer { get; set; }
        public bool? PickupSignatureAtArrivedSenderDepot { get; set; }
        public bool? PickupSignatureAtArrivedReceiverCustomer { get; set; }
        public bool? PickupSignatureAtArrivedReceiverDepot { get; set; }
        public bool? PickupWaitingTimeAtSenderCustomer { get; set; }
        public bool? PickupWaitingTimeAtSenderDepot { get; set; }
        public bool? PickupWaitingTimeAtReceiverCustomer { get; set; }
        public bool? PickupWaitingTimeAtReceiverDepot { get; set; }
        public bool? PickupTimestampsAtSenderCustomer { get; set; }
        public bool? PickupTimestampsAtSenderDepot { get; set; }
        public bool? PickupTimestampsAtReceiverCustomer { get; set; }
        public bool? PickupTimestampsAtReceiverDepot { get; set; }
        public bool? PickupScanAtSenderCustomer { get; set; }
        public bool? PickupScanAtSenderDepot { get; set; }
        public bool? PickupScanAtReceiverCustomer { get; set; }
        public bool? PickupScanAtReceiverDepot { get; set; }
        public bool? CourierSignatureAtArrivedSenderCustomer { get; set; }
        public bool? CourierSignatureAtArrivedSenderDepot { get; set; }
        public bool? CourierSignatureAtArrivedReceiverCustomer { get; set; }
        public bool? CourierSignatureAtArrivedReceiverDepot { get; set; }
        public bool? CourierWaitingTimeAtSenderCustomer { get; set; }
        public bool? CourierWaitingTimeAtSenderDepot { get; set; }
        public bool? CourierWaitingTimeAtReceiverCustomer { get; set; }
        public bool? CourierWaitingTimeAtReceiverDepot { get; set; }
        public bool? CourierTimestampsAtSenderCustomer { get; set; }
        public bool? CourierTimestampsAtSenderDepot { get; set; }
        public bool? CourierTimestampsAtReceiverCustomer { get; set; }
        public bool? CourierTimestampsAtReceiverDepot { get; set; }
        public bool? CourierScanAtSenderCustomer { get; set; }
        public bool? CourierScanAtSenderDepot { get; set; }
        public bool? CourierScanAtReceiverCustomer { get; set; }
        public bool? CourierScanAtReceiverDepot { get; set; }
        public bool? LinehaulSignatureAtArrivedSenderCustomer { get; set; }
        public bool? LinehaulSignatureAtArrivedSenderDepot { get; set; }
        public bool? LinehaulSignatureAtArrivedReceiverCustomer { get; set; }
        public bool? LinehaulSignatureAtArrivedReceiverDepot { get; set; }
        public bool? LinehaulWaitingTimeAtSenderCustomer { get; set; }
        public bool? LinehaulWaitingTimeAtSenderDepot { get; set; }
        public bool? LinehaulWaitingTimeAtReceiverCustomer { get; set; }
        public bool? LinehaulWaitingTimeAtReceiverDepot { get; set; }
        public bool? LinehaulTimestampsAtSenderCustomer { get; set; }
        public bool? LinehaulTimestampsAtSenderDepot { get; set; }
        public bool? LinehaulTimestampsAtReceiverCustomer { get; set; }
        public bool? LinehaulTimestampsAtReceiverDepot { get; set; }
        public bool? LinehaulScanAtSenderCustomer { get; set; }
        public bool? LinehaulScanAtSenderDepot { get; set; }
        public bool? LinehaulScanAtReceiverCustomer { get; set; }
        public bool? LinehaulScanAtReceiverDepot { get; set; }
        public bool? LinehaulAutoCreate { get; set; }
        public bool? MergePickupsAndCouriers { get; set; }
        public bool? MergeEverything { get; set; }
        public bool? DeliveryShowButtonArrivedSenderCustomer { get; set; }
        public bool? DeliveryShowButtonArrivedSenderDepot { get; set; }
        public bool? DeliveryShowButtonDepartedSenderCustomer { get; set; }
        public bool? DeliveryShowButtonDepartedSenderDepot { get; set; }
        public bool? DeliveryShowButtonArrivedReceiverCustomer { get; set; }
        public bool? DeliveryShowButtonArrivedReceiverDepot { get; set; }
        public bool? DeliveryShowButtonDepartedReceiverCustomer { get; set; }
        public bool? DeliveryShowButtonDepartedReceiverDepot { get; set; }
        public bool? PickupShowButtonArrivedSenderCustomer { get; set; }
        public bool? PickupShowButtonArrivedSenderDepot { get; set; }
        public bool? PickupShowButtonDepartedSenderCustomer { get; set; }
        public bool? PickupShowButtonDepartedSenderDepot { get; set; }
        public bool? PickupShowButtonArrivedReceiverCustomer { get; set; }
        public bool? PickupShowButtonArrivedReceiverDepot { get; set; }
        public bool? PickupShowButtonDepartedReceiverCustomer { get; set; }
        public bool? PickupShowButtonDepartedReceiverDepot { get; set; }
        public bool? CourierShowButtonArrivedSenderCustomer { get; set; }
        public bool? CourierShowButtonArrivedSenderDepot { get; set; }
        public bool? CourierShowButtonDepartedSenderCustomer { get; set; }
        public bool? CourierShowButtonDepartedSenderDepot { get; set; }
        public bool? CourierShowButtonArrivedReceiverCustomer { get; set; }
        public bool? CourierShowButtonArrivedReceiverDepot { get; set; }
        public bool? CourierShowButtonDepartedReceiverCustomer { get; set; }
        public bool? CourierShowButtonDepartedReceiverDepot { get; set; }
        public bool? LinehaulShowButtonArrivedSenderCustomer { get; set; }
        public bool? LinehaulShowButtonArrivedSenderDepot { get; set; }
        public bool? LinehaulShowButtonDepartedSenderCustomer { get; set; }
        public bool? LinehaulShowButtonDepartedSenderDepot { get; set; }
        public bool? LinehaulShowButtonArrivedReceiverCustomer { get; set; }
        public bool? LinehaulShowButtonArrivedReceiverDepot { get; set; }
        public bool? LinehaulShowButtonDepartedReceiverCustomer { get; set; }
        public bool? LinehaulShowButtonDepartedReceiverDepot { get; set; }
        public string? Subdomain { get; set; }
        public bool ShowTrackingCodeOnLogin { get; set; }
        public bool ShowConsignmentsPage { get; set; }
        public string? TermsAndConditions { get; set; }
        public string? Address { get; set; }
        public string? State { get; set; }
        public string? Postcode { get; set; }
        public string? City { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public bool? BookingFormInPodapp { get; set; }
        public string? Podfooter { get; set; }
        public string? Website { get; set; }
        public string? Email { get; set; }
        public bool? PodexceptionPhotos { get; set; }
        public bool? ShowReleaseNumberOnJobLegs { get; set; }
        public bool? BookingFormEnabled { get; set; }
        public bool? ShowBarcodeOnProducts { get; set; }
        public bool? ShowTermsAndConditionsCustomerUser { get; set; }
        public string? DropboxToken { get; set; }
        public string? DropboxSecret { get; set; }
        public bool? UploadPoddropbox { get; set; }
        public bool? UploadManifestDropbox { get; set; }
        public bool? UploadSignituresDropbox { get; set; }
        public bool? UploadExceptionPhotosDropbox { get; set; }
        public bool? UseDropbox { get; set; }
        public bool? UploadDriverSignitureDropbox { get; set; }
        public string? ManifestNumberPrefix { get; set; }
        public bool? UseCustomEdifolderDropbox { get; set; }
        public string? Ftpserver { get; set; }
        public string? Ftpusername { get; set; }
        public string? Ftppassword { get; set; }
        public bool? UseFtp { get; set; }
        public long? ManifestNumberLastIndex { get; set; }
        public string? Timezone { get; set; }
        public Guid? Suburb { get; set; }
        public bool? UploadPodcustomerFolderDropbox { get; set; }
        public bool? UseFoxPro { get; set; }
        public string? DropboxEmail { get; set; }
        public bool UseCustomTrackingScreen { get; set; }
        public bool UseCustomBookingEmail { get; set; }
        public string? CustomBookingEmail { get; set; }
        public string? ProductCustomFieldLabel01 { get; set; }
        public string? ProductCustomFieldLabel02 { get; set; }
        public string? ProductCustomFieldLabel03 { get; set; }
        public string? ProductCustomFieldLabel04 { get; set; }
        public string? ProductCustomFieldLabel05 { get; set; }
        public bool UseProductCustomFields { get; set; }
        public bool PalletControlPickup { get; set; }
        public bool PalletControlDelivery { get; set; }
        public bool PickupPalletManagement { get; set; }
        public bool PalletControlMandatoryPalletNo { get; set; }
        public bool PalletControlDisplayOnPanel { get; set; }
        public bool UseFastDispatch { get; set; }
        public int BookingFormButtonsPosition { get; set; }
        public bool BookingFormConfirmation { get; set; }
        public bool UsePodphotographs { get; set; }
        public string ConsignmentsLabel { get; set; } = null!;
        public string? DefaultJobKindId { get; set; }
        public bool UseAutoManifestAppend { get; set; }
        public bool SplitCourierLegs { get; set; }
        public bool EdiautoLeg { get; set; }
        public bool EdiautoManifest { get; set; }
        public bool? PrintPodsignatures { get; set; }
        public bool? ShowJobKindOnBooking { get; set; }
        public bool? ShowFoxProCodes { get; set; }
        public bool UseCrossDock { get; set; }
        public bool UseCustomCss { get; set; }
        public bool UseTimeSlot { get; set; }
        public bool ShowAdditionalFieldsForCustomers { get; set; }
        public int CountryId { get; set; }
        public bool FoxProExportWholeStructure { get; set; }
        public bool UseManifestLegValidation { get; set; }
        public bool ShowTimeSlot { get; set; }
        public bool ShowTrackingCode { get; set; }
        public bool ShowNewSenderButton { get; set; }
        public bool ShowNewRecipientButton { get; set; }
        public bool ShowPalletsAndCartonOnly { get; set; }
        public bool ShowNewProductButton { get; set; }
        public bool ShowDgcheckBox { get; set; }
        public bool UseGlobalAlert { get; set; }
        public bool ExportToFoxProFromBooking { get; set; }
        public bool ExportToFoxProFromEnquiry { get; set; }
        public bool ExportToFoxProFromOperations { get; set; }
        public bool GroupJobLegsBySender { get; set; }
        public bool GroupJobLegsByRecipient { get; set; }
        public bool DeliveryShowEtabuttonCustomer { get; set; }
        public bool PickupShowEtabuttonCustomer { get; set; }
        public bool CourierShowEtabuttonCustomer { get; set; }
        public bool LinehaulShowEtabuttonCustomer { get; set; }
        public bool DeliveryShowEtabuttonDepot { get; set; }
        public bool PickupShowEtabuttonDepot { get; set; }
        public bool CourierShowEtabuttonDepot { get; set; }
        public bool LinehaulShowEtabuttonDepot { get; set; }
        public bool SendSuccessPodemail { get; set; }
        public bool? SendFailedPodemail { get; set; }
        public bool? SendIssuesPodemail { get; set; }
        public bool RenameSenderRecipient { get; set; }
        public string? SenderLabel { get; set; }
        public string? RecipientLabel { get; set; }
        public bool? UseCustomerDueTimestamp { get; set; }
        public bool UseFolderWatcher { get; set; }
        public string? Path { get; set; }
        public int LastWriteIntervalSeconds { get; set; }
        public int TimerIntervalSeconds { get; set; }
        public bool SchedulerImportCustomer { get; set; }
        public bool SchedulerImportLocations { get; set; }
        public bool SchedulerImportInvoices { get; set; }
        public bool SchedulerExportJobs { get; set; }
        public bool ShowInvoice { get; set; }
        public bool CreateConsignmentNoteOnBooking { get; set; }
        public bool FoxProExportPod { get; set; }
        public bool IsEtamandatory { get; set; }
        public bool IsEtavisible { get; set; }
        public string? DefaultTripStatusId { get; set; }
        public bool? AllowMultipleJobs { get; set; }
        public bool ContinueIfNegative { get; set; }
        public bool ShowNoteForInvalidAnswer { get; set; }
        public bool SchedulerImportJobs { get; set; }
        public bool ShowVehiclesRegistration { get; set; }
        public bool EnquiryDepotFilterForCustomer { get; set; }
        public bool CustomNumberOfRecords { get; set; }
        public int EnqueryRecords { get; set; }
        public int InvoicesRecords { get; set; }
        public int InvoiceDetailsRecords { get; set; }
        public bool ShowFoxProNumberOnBooking { get; set; }
        public bool ShowPodbutton { get; set; }
        public bool AllowDeletingJobEnquiry { get; set; }
        public bool ShowUserMenu { get; set; }
        public bool ShowProductMenu { get; set; }
        public bool ShowLocationMenu { get; set; }
        public bool ShowAllDataForCompanyStaff { get; set; }
        public bool SchedulerImportVehiclesTrailers { get; set; }
        public bool SchedulerImportProducts { get; set; }
        public bool SendPodtoCentralEmailAddress { get; set; }
        public bool ShowDashboard { get; set; }
        public bool? ShowProductSummaryInJobLegsList { get; set; }
        public bool SchedulerExportCustomers { get; set; }
        public bool SchedulerExportLocations { get; set; }
        public bool SchedulerExportDrivers { get; set; }
        public bool SchedulerExportVehicles { get; set; }
        public bool SchedulerExportTrailers { get; set; }
        public bool SchedulerExportProducts { get; set; }
        public bool SetConsStartedOnDispatched { get; set; }
        public int? AvailableJobHistoryMonthsNo { get; set; }
        public string? CustomTextForJobRef { get; set; }
        public bool AllowCancelBookingToCustomers { get; set; }
        public bool AllowUnapprovedLocations { get; set; }
        public string? States { get; set; }
        public bool ShowCanceledJobs { get; set; }
        public bool AllowJobEditingToCustomers { get; set; }
        public bool ShowLocationCodes { get; set; }
        public bool ShowCustomerCodes { get; set; }
        public bool AllowCustomerDeleteLocations { get; set; }
        public bool ShowInactiveLocationsForCustomers { get; set; }
        public string? CustomBookingMessage { get; set; }
        public bool AllowCustomerEditLocations { get; set; }
        public bool ShowProductCodes { get; set; }
        public bool ShowVehicleCodes { get; set; }
        public bool ShowUserCodes { get; set; }
        public bool JobLegsColapsed { get; set; }
        public bool ProductsColapsed { get; set; }
        public bool PalletTrackingColapsed { get; set; }
        public bool AutoGenerateLegs { get; set; }
        public string? DefaultPalletType { get; set; }
        public bool DispatchFromBooking { get; set; }
        public Guid? DefaultDepotId { get; set; }
        public decimal TaxRate { get; set; }
        public int? DefaultJobSourceId { get; set; }
        public bool? IsCustomerNameUnique { get; set; }
        public TimeSpan? CustomerCanEditJobUntil { get; set; }
        public bool AllowCustomerToChangePassword { get; set; }
        public bool UploadPoddefaultFolderDropbox { get; set; }
        public int AddDaysRequiredDate { get; set; }
        public bool ShowRequiredDateEnquiryCustomers { get; set; }
        public int? AfterBookingRouteId { get; set; }
        public bool HideJobLegsOnBooking { get; set; }
        public bool AllowDistrfromCustomerDl { get; set; }
        public bool DisplayNewFeature { get; set; }
        public bool EnquiryShowPostCodeFilterCustomers { get; set; }
        public int? BookingTemplateId { get; set; }
        public bool AutocreateDailyManifest { get; set; }
        public bool RebookFailedJobLegs { get; set; }
        public string DefaultJobStatusIdforClientUsers { get; set; } = null!;
        public bool CustomerBookingMandatoryReceiverPhone { get; set; }
        public bool EnablePrintLabels { get; set; }
        public bool EnableInvoicing { get; set; }
        public string? SendInvoiceMethodId { get; set; }
        public string? AccountingSystemId { get; set; }
        public string? InterfaceTypeId { get; set; }
        public string InvoicingGroupingId { get; set; } = null!;
        public string? InvoiceNumberPrefix { get; set; }
        public int InvoiceStartingNumber { get; set; }
        public string? InvoiceDeliveryMethodId { get; set; }
        public string? PaymentTermsId { get; set; }
        public string? AllowPricingConfirmationJobStatusId { get; set; }
        public string InvoicingFrequencyId { get; set; } = null!;
        public string? InterfaceVersionId { get; set; }
        public bool EnableLocationApproval { get; set; }
        public int LabelTemplateId { get; set; }
        public int InvoiceTemplateId { get; set; }
        public string? Bank { get; set; }
        public string? PostalAddress { get; set; }
        public string? PostalStateId { get; set; }
        public string? PostalPostCode { get; set; }
        public string? GeneralMessage { get; set; }
        public string? BankingMessage { get; set; }
        public string? Abn { get; set; }
        public string? RemittanceMail { get; set; }
        public Guid? PostalSuburbId { get; set; }
        public bool ScheduleDropboxPodupload { get; set; }
        public bool ShowInvoicingToCustomers { get; set; }
        public string ProductDimensionEntry { get; set; } = null!;
        public bool UseAdditionalFieldsRequiredDate { get; set; }
        public Guid? GstcodeId { get; set; }
        public bool BackToDepot { get; set; }
        public bool AutoDispatchTodayManifest { get; set; }
        public int? BookingScreenTemplateId { get; set; }
        public int? PodtemplateId { get; set; }
        public int? ConnoteTemplateId { get; set; }
        public bool EnableGoogleMaps { get; set; }
        public bool EnableGpshistory { get; set; }
        public int? MapDefaultCentreId { get; set; }
        public string? JobTotalsGridSetup { get; set; }
        public int CubicWeightConvRate { get; set; }
        public string? JobWeightType { get; set; }
        public bool? UseInvoiceExport { get; set; }
        public Guid? ExportInvoiceTemplateId { get; set; }
        public bool InvoiceAttachPod { get; set; }
        public bool UseAccountReferenceAsInvoiceNumber { get; set; }
        public bool PaymentTermsEop { get; set; }
        public string? DebugEmail { get; set; }
        public string? InvoiceCopyEmail { get; set; }
        public bool? RequirePod { get; set; }
        public bool? RequireCustomerPodpaperwork { get; set; }
        public bool? RequirePodbeforeInvoicing { get; set; }
        public bool? InvoiceOnlyModeBooking { get; set; }
        public bool ShowLocationContactOnBookingScreen { get; set; }
        public bool ShowBookingContactOnBookingScreen { get; set; }
        public bool? ShowDepotZoneWarningOnBookingScreen { get; set; }
        public int? DefMapReloadTime { get; set; }
        public bool ShowSublocations { get; set; }
        public string? Reference1Title { get; set; }
        public string? Reference2Title { get; set; }
        public string? Reference3Title { get; set; }
        public string? Reference4Title { get; set; }
        public string? Reference5Title { get; set; }
        public string? Reference6Title { get; set; }
        public string? Reference7Title { get; set; }
        public string? Reference8Title { get; set; }
        public string? Reference9Title { get; set; }
        public string? Reference10Title { get; set; }
        public bool ValidateLegsInvoicingOnly { get; set; }
        public bool? EnableGoogleMapsForNewLocationCreation { get; set; }
        public string SendInvoicesTo { get; set; } = null!;
        public bool ShowServiceCode { get; set; }
        public bool? EnableGoogleMapsForManifest { get; set; }
        public bool SummarizePricingsOnInvoiceLevel { get; set; }
        public string? LegValidationMethod { get; set; }
        public string? LegCreationMethod { get; set; }
        public bool SummarizeCostingsOnSpalevel { get; set; }
        public bool? UsingApp { get; set; }
        public bool? MandatoryGroupingOfPriceItems { get; set; }
        public bool? MandatoryGroupingOfCostItems { get; set; }
        public bool? EnterProductWeightAndCubicAsTotal { get; set; }
        public string? SpanumberPrefix { get; set; }
        public int SpastartingNumber { get; set; }
        public bool? SplitPriceByLegRule { get; set; }
        public string? SplitPriceRulesId { get; set; }
        public string? EmailSenderReplyToMail { get; set; }
        public string? EmailSenderTitle { get; set; }
        public bool? IsLocationAvailableToLegs { get; set; }
        public int SpainvoiceTemplateId { get; set; }
        public bool? AllLegsPodareJobPods { get; set; }
        public Guid? JobImportModeId { get; set; }
        public Guid? BookingPrintOptionsId { get; set; }
        public bool? ShowDriverTimePicker { get; set; }
        public bool? ShowDriverWorkingTimeOnApp { get; set; }
        public Guid? CubicWeightConvRateId { get; set; }
        public bool? ShowDateFieldsOnCustomerBooking { get; set; }
        public int? EmailAttachmentDeletionFrequency { get; set; }
        public string? Bpaynumber { get; set; }
        public bool? ShowNavigationToDriver { get; set; }
        public DateTime? CloseOffDate { get; set; }
        public string? PaymentPrefix { get; set; }
        public string? CreditNotePrefix { get; set; }
        public int PaymentStartingNumber { get; set; }
        public int CreditNoteStartingNumber { get; set; }
        public bool EnableTrackAndTrace { get; set; }
        public bool SwitchToEnquiryV2 { get; set; }
        public string? DebugEmailEdi { get; set; }
        public string? StripePublishableKey { get; set; }
        public string? StripeSecretKey { get; set; }
        public bool DisableSubtotalProductsBeforePricing { get; set; }
        public bool PaymentGatewayVisible { get; set; }
        public bool ShowPalletEntry { get; set; }
        public int ManifestReportId { get; set; }
        public bool ManifestReportPrintBackPage { get; set; }
        public bool? ShowShippingUnits { get; set; }
        public bool CustomerBookingMandatoryServiceCode { get; set; }
        public bool CustomerBookingMandatoryInstructions { get; set; }
        public bool CustomerBookingMandatoryDropedPickedDepot { get; set; }
        public bool AttachSpod { get; set; }
        public bool? ShowDocumentsToMultiCustomerUser { get; set; }
        public bool? ShowDocumentsToCustomerUser { get; set; }
        public int CombinedConsignmentNoteLastNumber { get; set; }
        public bool DoNotUseAppPodIfAlternativePodIsAvailable { get; set; }
        public string? BouncedDebugEmail { get; set; }
        public bool AllowCustomerCreationFromBooking { get; set; }
        public bool ShowProductPalletOnBooking { get; set; }
        public byte PricingScheduleSelectionLogic { get; set; }
        public string? PaymentTermsNewCustomer { get; set; }
        public bool PaymentTermsEopnewCustomer { get; set; }
        public string? ManifestTotalsGridSetup { get; set; }
        public Guid? DefaultServiceId { get; set; }
        public bool UseCompliance { get; set; }
        public bool ChecklistAndSignature { get; set; }
        public bool SameReceiverLegsAreJobPods { get; set; }
        public bool SwitchToInvoiceEnquiryV2 { get; set; }
        public bool EnablePalletManagement { get; set; }
        public bool UseProductsOnLegs { get; set; }
        public bool FinishedJobProductEditable { get; set; }
        public bool UseUserDepotAsJobDepot { get; set; }
        public bool UseAccountCodeFromJob { get; set; }
        public string? GroupLabels { get; set; }
        public bool NotSelectOptPricingsAfterCalc { get; set; }
        public string? DefaultManifestType { get; set; }
        public bool ShowReviewActivity { get; set; }
        public string? Division { get; set; }
        public bool GroupProductsByShippingUnit { get; set; }
        public bool UpdateLegsFromJob { get; set; }
        public bool AllowJobUpdateInProcess { get; set; }
        public string? PricingQuickFeatures { get; set; }
        public DateTime? BeyondDate { get; set; }
        public bool ShowSmartFreight { get; set; }
        public bool ShowHiTrans { get; set; }
        public bool LegEditingOnOperations { get; set; }
        public string? JobLegColumnOrder { get; set; }
        public bool ShowSendEdi { get; set; }
        public bool SplitExpenseByLegRule { get; set; }
        public bool InvoiceGstdirectCalc { get; set; }
        public string? XeroClientId { get; set; }
        public string? XeroClientSecret { get; set; }
        public bool ShowXeroPricingItems { get; set; }
        public string? SplitExpenseRulesId { get; set; }
        public bool XeroSyncTmspricingsWithXero { get; set; }
        public bool ShowGroup1OnBooking { get; set; }
        public bool ShowGroup2OnBooking { get; set; }
        public bool ShowFleetCode { get; set; }
        public bool DisableShowGlobalProfile { get; set; }
        public string? ProductWeightEntry { get; set; }
        public string? TinyUrlAuthToken { get; set; }
        public string? TwilioAccountSid { get; set; }
        public string? TwilioAuthToken { get; set; }
        public string? TwilioFromNumber { get; set; }
        public bool SetCostZoneAnyIfEmpty { get; set; }
        public bool UsePartialFilterBatch { get; set; }
        public bool XeroSyncTmscustomersWithXero { get; set; }
        public bool XeroSyncXeroPricingsWithTms { get; set; }
        public string? XeroAccountCodePrefix { get; set; }
        public bool AllowCustomerEntryBeforeAddress { get; set; }
        public bool RestrictAddressLocationToCustomer { get; set; }
        public string? ManifestTotalsLogicClass { get; set; }
        public string? UsedTolls { get; set; }

        public virtual AccountingSystem? AccountingSystem { get; set; }
        public virtual AfterBookingRoute? AfterBookingRoute { get; set; }
        public virtual BookingPrintOption? BookingPrintOptions { get; set; }
        public virtual ViewTemplate? BookingScreenTemplate { get; set; }
        public virtual ViewTemplate? BookingTemplate { get; set; }
        public virtual Report? ConnoteTemplate { get; set; }
        public virtual Country Country { get; set; } = null!;
        public virtual CubicWeightConversionRate? CubicWeightConvRateNavigation { get; set; }
        public virtual Location? DefaultDepot { get; set; }
        public virtual JobSource? DefaultJobSource { get; set; }
        public virtual TripStatus? DefaultTripStatus { get; set; }
        public virtual Gstcode? Gstcode { get; set; }
        public virtual InterfaceType? InterfaceType { get; set; }
        public virtual InterfaceVersion? InterfaceVersion { get; set; }
        public virtual InvoiceDeliveryMethod? InvoiceDeliveryMethod { get; set; }
        public virtual Report InvoiceTemplate { get; set; } = null!;
        public virtual InvoicingFrequency InvoicingFrequency { get; set; } = null!;
        public virtual InvoicingGrouping InvoicingGrouping { get; set; } = null!;
        public virtual JobImportMode? JobImportMode { get; set; }
        public virtual Report LabelTemplate { get; set; } = null!;
        public virtual LegCreationMethod? LegCreationMethodNavigation { get; set; }
        public virtual Report ManifestReport { get; set; } = null!;
        public virtual MapDefaultCentre? MapDefaultCentre { get; set; }
        public virtual PaymentTerm? PaymentTerms { get; set; }
        public virtual Report? Podtemplate { get; set; }
        public virtual State? PostalState { get; set; }
        public virtual Suburb? PostalSuburb { get; set; }
        public virtual SendInvoiceMethod? SendInvoiceMethod { get; set; }
        public virtual SplitExpenseRule? SplitExpenseRules { get; set; }
        public virtual SplitPriceRule? SplitPriceRules { get; set; }
        public virtual State? StateNavigation { get; set; }
        public virtual Suburb? SuburbNavigation { get; set; }
        public virtual ICollection<AccountingSystemInstance> AccountingSystemInstances { get; set; }
        public virtual ICollection<Activity> Activities { get; set; }
        public virtual ICollection<Apikey> Apikeys { get; set; }
        public virtual ICollection<AutomaticEdilog> AutomaticEdilogs { get; set; }
        public virtual ICollection<CheckList> CheckLists { get; set; }
        public virtual ICollection<CompanyCompliance> CompanyCompliances { get; set; }
        public virtual ICollection<CompanyHistory> CompanyHistories { get; set; }
        public virtual ICollection<CompanyToll> CompanyTolls { get; set; }
        public virtual ICollection<Compliance> Compliances { get; set; }
        public virtual ICollection<ConsolidatedConsignmentNote> ConsolidatedConsignmentNotes { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<CostingSchedule> CostingSchedules { get; set; }
        public virtual ICollection<CreditNoteSalesLedger> CreditNoteSalesLedgers { get; set; }
        public virtual ICollection<CubicWeightConversionRate> CubicWeightConversionRates { get; set; }
        public virtual ICollection<CustomActivityProduct> CustomActivityProducts { get; set; }
        public virtual ICollection<CustomPage> CustomPages { get; set; }
        public virtual ICollection<CustomerLocation> CustomerLocations { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<DeviceCrashLog> DeviceCrashLogs { get; set; }
        public virtual ICollection<Edilog> Edilogs { get; set; }
        public virtual ICollection<EmailQueue> EmailQueues { get; set; }
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
        public virtual ICollection<FleetRunningCost> FleetRunningCosts { get; set; }
        public virtual ICollection<FoxProSyncDate> FoxProSyncDates { get; set; }
        public virtual ICollection<GenericGroup> GenericGroups { get; set; }
        public virtual ICollection<GlobalAlert> GlobalAlerts { get; set; }
        public virtual ICollection<GridStateProfile> GridStateProfiles { get; set; }
        public virtual ICollection<InvoiceBatch> InvoiceBatches { get; set; }
        public virtual ICollection<Invoice> Invoices { get; set; }
        public virtual ICollection<JobCancelReason> JobCancelReasons { get; set; }
        public virtual ICollection<JobCode> JobCodes { get; set; }
        public virtual ICollection<JobDocumentType> JobDocumentTypes { get; set; }
        public virtual ICollection<JobImportMode> JobImportModes { get; set; }
        public virtual ICollection<JobSenderRecipientDefault> JobSenderRecipientDefaults { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Location> Locations { get; set; }
        public virtual ICollection<ManifestName> ManifestNames { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<MobileDevice> MobileDevices { get; set; }
        public virtual ICollection<PalletAccount> PalletAccounts { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
        public virtual ICollection<PricingScheduleType> PricingScheduleTypes { get; set; }
        public virtual ICollection<PricingSchedule> PricingSchedules { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
        public virtual ICollection<ProductLocation> ProductLocations { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<PublicHoliday> PublicHolidays { get; set; }
        public virtual ICollection<RecurrenceJobSchedule> RecurrenceJobSchedules { get; set; }
        public virtual ICollection<ReferenceType> ReferenceTypes { get; set; }
        public virtual ICollection<ReportCompanyList> ReportCompanyLists { get; set; }
        public virtual ICollection<ServiceCode> ServiceCodes { get; set; }
        public virtual ICollection<ServiceLane> ServiceLanes { get; set; }
        public virtual ICollection<Smsqueue> Smsqueues { get; set; }
        public virtual ICollection<Spabatch> Spabatches { get; set; }
        public virtual ICollection<Subcontractor> Subcontractors { get; set; }
        public virtual ICollection<SuburbDistanceConfig> SuburbDistanceConfigs { get; set; }
        public virtual ICollection<Suburb> Suburbs { get; set; }
        public virtual ICollection<TimeSlot> TimeSlots { get; set; }
        public virtual ICollection<Tmsapi> Tmsapis { get; set; }
        public virtual ICollection<TransactionTable> TransactionTables { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<WebPanelUser> WebPanelUsers { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
    }
}
