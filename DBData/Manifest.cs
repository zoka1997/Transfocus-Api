using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Manifest
    {
        public Manifest()
        {
            DriverWorkingTimes = new HashSet<DriverWorkingTime>();
            JobLegCostingStatusHistories = new HashSet<JobLegCostingStatusHistory>();
            JobLegCostings = new HashSet<JobLegCosting>();
            JobLegs = new HashSet<JobLeg>();
            ManifestHistories = new HashSet<ManifestHistory>();
            MobileLogs = new HashSet<MobileLog>();
            Notifications = new HashSet<Notification>();
            RevokedManifestJobLegs = new HashSet<RevokedManifestJobLeg>();
            RoadTolls = new HashSet<RoadToll>();
        }

        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? ModifiedBy { get; set; }
        public Guid DriverId { get; set; }
        public string ManifestNumber { get; set; } = null!;
        public string? Notes { get; set; }
        public string ManifestStatusId { get; set; } = null!;
        public Guid CompanyId { get; set; }
        public Guid? VehicleId { get; set; }
        public Guid? Trailer1Id { get; set; }
        public Guid? Trailer2Id { get; set; }
        public string? Name { get; set; }
        public Guid? ZoneId { get; set; }
        public string? FoxProManifestNumber { get; set; }
        public DateTime? Date { get; set; }
        public string? ManifestType { get; set; }
        public Guid? FleetConfigurationId { get; set; }
        public Guid? LinehaulManifestFrom { get; set; }
        public Guid? LinehaulManifestTo { get; set; }
        public string? TrailerConfigurationOld { get; set; }
        public bool ExpenseCalculated { get; set; }
        public int? TrailerConfigurationId { get; set; }
        public decimal? ManifestKilometers { get; set; }
        public decimal? ManifestHours { get; set; }
        public DateTime? Start { get; set; }
        public DateTime? Finish { get; set; }
        public decimal TimeToSite { get; set; }
        public decimal ReturnTime { get; set; }
        public int LoadingTimeMinutes { get; set; }
        public int WaitingTimeMinutes { get; set; }
        public decimal CustomerHours { get; set; }
        public decimal DriverHours { get; set; }
        public decimal DriverBreak1 { get; set; }
        public decimal DriverBreak2 { get; set; }
        public string? CostingStatusId { get; set; }
        public Guid? PanelInvoiceId { get; set; }
        public decimal Cost { get; set; }
        public Guid? ServiceCodeId { get; set; }
        public bool AutoCostComplete { get; set; }
        public string? AutoCostingLog { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CostingStatus? CostingStatus { get; set; }
        public virtual User Driver { get; set; } = null!;
        public virtual FleetConfiguration? FleetConfiguration { get; set; }
        public virtual Location? LinehaulManifestFromNavigation { get; set; }
        public virtual Location? LinehaulManifestToNavigation { get; set; }
        public virtual ManifestStatus ManifestStatus { get; set; } = null!;
        public virtual ManifestType? ManifestTypeNavigation { get; set; }
        public virtual PanelInvoice? PanelInvoice { get; set; }
        public virtual ServiceCode? ServiceCode { get; set; }
        public virtual Vehicle? Trailer1 { get; set; }
        public virtual Vehicle? Trailer2 { get; set; }
        public virtual TrailerConfiguration? TrailerConfiguration { get; set; }
        public virtual Vehicle? Vehicle { get; set; }
        public virtual Zone? Zone { get; set; }
        public virtual ICollection<DriverWorkingTime> DriverWorkingTimes { get; set; }
        public virtual ICollection<JobLegCostingStatusHistory> JobLegCostingStatusHistories { get; set; }
        public virtual ICollection<JobLegCosting> JobLegCostings { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<ManifestHistory> ManifestHistories { get; set; }
        public virtual ICollection<MobileLog> MobileLogs { get; set; }
        public virtual ICollection<Notification> Notifications { get; set; }
        public virtual ICollection<RevokedManifestJobLeg> RevokedManifestJobLegs { get; set; }
        public virtual ICollection<RoadToll> RoadTolls { get; set; }
    }
}
