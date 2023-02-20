using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class TripEnquiryView
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public Guid? CompanyId { get; set; }
        public string JobNumber { get; set; } = null!;
        public long? JobNumberNumeral { get; set; }
        public DateTime? JobDate { get; set; }
        public DateTime? JobDateEntered { get; set; }
        public string JobEnteredBy { get; set; } = null!;
        public string? Customer { get; set; }
        public string? CustomerEntity { get; set; }
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
        public string? Contact { get; set; }
        public string? JobService { get; set; }
        public string? JobDepot { get; set; }
        public DateTime? JobReady { get; set; }
        public decimal? JobReadyFromCustomOffset { get; set; }
        public DateTime? JobRequired { get; set; }
        public decimal? JobRequiredCustomOffset { get; set; }
        public string? JobStatusId { get; set; }
        public string? JobStatus { get; set; }
        public string? JobStatusColor { get; set; }
        public string? JobPriceStatusId { get; set; }
        public string? JobPriceStatus { get; set; }
        public string? JobPriceStatusColor { get; set; }
        public string? JobProductOwner { get; set; }
        public string? JobBookingType { get; set; }
        public string? JobWeightType { get; set; }
        public decimal? JobQuantity { get; set; }
        public decimal? JobPallets { get; set; }
        public decimal? JobWeight { get; set; }
        public decimal? JobCubicWeight { get; set; }
        public decimal? JobSpace { get; set; }
        public decimal? JobKms { get; set; }
        public decimal? JobHours { get; set; }
        public decimal? JobWaiting { get; set; }
        public int? JobDrops { get; set; }
        public string? JobSenderNote { get; set; }
        public DateTime? JobReadyDate { get; set; }
        public Guid? SenderId { get; set; }
        public string? SenderPhone { get; set; }
        public string? SenderPostcode { get; set; }
        public string? SenderName { get; set; }
        public DateTime? SenderArrive { get; set; }
        public DateTime? ReceiverArrive { get; set; }
        public DateTime? SenderDepart { get; set; }
        public DateTime? ReceiverDepart { get; set; }
        public int? SenderWait { get; set; }
        public int? ReceiverWait { get; set; }
        public string? Note { get; set; }
        public string? SenderLocation { get; set; }
        public string? JobReceiverNote { get; set; }
        public Guid? ReceiverId { get; set; }
        public string? ReceiverPhone { get; set; }
        public string? ReceiverPostcode { get; set; }
        public string? ReceiverState { get; set; }
        public string? ReceiverName { get; set; }
        public string? ReceiverLocation { get; set; }
        public string? JobInstructions { get; set; }
        public string LegNumber { get; set; } = null!;
        public DateTime? LegDate { get; set; }
        public string? LegType { get; set; }
        public string? LegService { get; set; }
        public string? LegDepot { get; set; }
        public string? LegManifest { get; set; }
        public string? ManifestName { get; set; }
        public Guid? LegManifestId { get; set; }
        public Guid? DriverId { get; set; }
        public string? LegDriver { get; set; }
        public string? LegDriverTypeId { get; set; }
        public string? LegDriverType { get; set; }
        public Guid? LegVehicleId { get; set; }
        public string? LegVehicle { get; set; }
        public Guid? LegTrailer1Id { get; set; }
        public string? LegTrailer1 { get; set; }
        public Guid? LegTrailer2Id { get; set; }
        public string? LegTrailer2 { get; set; }
        public Guid? LegTrailer3Id { get; set; }
        public string? LegTrailer3 { get; set; }
        public decimal LegNettCost { get; set; }
        public decimal LegCost { get; set; }
        public decimal LegExpense { get; set; }
        public decimal LegRevenue { get; set; }
        public decimal? LegProfit { get; set; }
        public decimal? LegProfitPercentage { get; set; }
        public decimal? LegProfitPerKilometer { get; set; }
        public string? LegStatusId { get; set; }
        public string? LegStatus { get; set; }
        public string? LegStatusColor { get; set; }
        public string LegTripStatusId { get; set; } = null!;
        public string? LegTripStatus { get; set; }
        public string? LegTripStatusColor { get; set; }
        public string? LegCostingStatusId { get; set; }
        public string? LegCostingStatus { get; set; }
        public string? LegCostingStatusColor { get; set; }
        public Guid? LegFromId { get; set; }
        public string? LegFromName { get; set; }
        public string? LegFromDetails { get; set; }
        public string LegFromAddress { get; set; } = null!;
        public string? LegFromSuburb { get; set; }
        public string? LegFromState { get; set; }
        public string? LegFromPostcode { get; set; }
        public string? LegFromAllocationZone { get; set; }
        public string? LegFromCostingZone { get; set; }
        public Guid? LegToId { get; set; }
        public string? LegToName { get; set; }
        public string? Podstatus { get; set; }
        public DateTime? PodsignatureTimestamp { get; set; }
        public string? PodsignedBy { get; set; }
        public string? PodexceptionId { get; set; }
        public string? PodexceptionNote { get; set; }
        public string? PodreceiverAppNote { get; set; }
        public string? LegToDetails { get; set; }
        public string LegToAddress { get; set; } = null!;
        public string? LegToSuburb { get; set; }
        public string? LegToState { get; set; }
        public string? LegToPostcode { get; set; }
        public string? LegToAllocationZone { get; set; }
        public string? LegToCostingZone { get; set; }
        public decimal? LegQuantity { get; set; }
        public decimal? LegKilometers { get; set; }
        public decimal? LegHours { get; set; }
        public string? Products { get; set; }
    }
}
