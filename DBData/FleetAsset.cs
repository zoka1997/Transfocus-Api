using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetAsset
    {
        public FleetAsset()
        {
            AuthTokens = new HashSet<AuthToken>();
            CompanyCompliances = new HashSet<CompanyCompliance>();
            FleetAssetAdditionalDetails = new HashSet<FleetAssetAdditionalDetail>();
            FleetAssetAttachments = new HashSet<FleetAssetAttachment>();
            FleetAssetAxleWeights = new HashSet<FleetAssetAxleWeight>();
            FleetAssetCapacities = new HashSet<FleetAssetCapacity>();
            FleetConfigurationFleetAssetId2Navigations = new HashSet<FleetConfiguration>();
            FleetConfigurationFleetAssetId3Navigations = new HashSet<FleetConfiguration>();
            FleetConfigurationFleetAssetId4Navigations = new HashSet<FleetConfiguration>();
            FleetConfigurationFleetAssets = new HashSet<FleetConfiguration>();
            OdometerReadings = new HashSet<OdometerReading>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? LocationId { get; set; }
        public string? Code { get; set; }
        public string? FleetNo { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Description { get; set; }
        public int? Year { get; set; }
        public int? FleetAssetTypeId { get; set; }
        public int? FleetAssetSubtypeId { get; set; }
        public int? FleetAssetMakeId { get; set; }
        public int? FleetAssetModelId { get; set; }
        public string? VinNo { get; set; }
        public int? FleetAssetFuelTypeId { get; set; }
        public bool? Active { get; set; }
        public bool ExportedToFoxPro { get; set; }
        public Guid? JobCodeId { get; set; }
        public int? Pallets { get; set; }
        public int? Spaces { get; set; }
        public decimal? Tare { get; set; }
        public decimal? Gcm { get; set; }
        public decimal? Gvm { get; set; }
        public decimal? CubicSum { get; set; }
        public decimal? InternalHeight { get; set; }
        public decimal? InternalWidth { get; set; }
        public decimal? InternalLength { get; set; }
        public string? Notes { get; set; }
        public string? SerialNo { get; set; }
        public string? InsuranceCompany { get; set; }
        public string? InsuranceCover { get; set; }
        public string? SumInsured { get; set; }
        public string? Excess { get; set; }
        public string? FinanceCompany { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? Group2Id { get; set; }
        public int? CostGroupId { get; set; }
        public Guid? SubcontractorId { get; set; }
        public bool IsSubcontractorsFleetAsset { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual CostGroup? CostGroup { get; set; }
        public virtual FleetAssetFuelType? FleetAssetFuelType { get; set; }
        public virtual FleetAssetMake? FleetAssetMake { get; set; }
        public virtual FleetAssetModel? FleetAssetModel { get; set; }
        public virtual FleetAssetSubtype? FleetAssetSubtype { get; set; }
        public virtual FleetAssetType? FleetAssetType { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual JobCode? JobCode { get; set; }
        public virtual Location? Location { get; set; }
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual ICollection<AuthToken> AuthTokens { get; set; }
        public virtual ICollection<CompanyCompliance> CompanyCompliances { get; set; }
        public virtual ICollection<FleetAssetAdditionalDetail> FleetAssetAdditionalDetails { get; set; }
        public virtual ICollection<FleetAssetAttachment> FleetAssetAttachments { get; set; }
        public virtual ICollection<FleetAssetAxleWeight> FleetAssetAxleWeights { get; set; }
        public virtual ICollection<FleetAssetCapacity> FleetAssetCapacities { get; set; }
        public virtual ICollection<FleetConfiguration> FleetConfigurationFleetAssetId2Navigations { get; set; }
        public virtual ICollection<FleetConfiguration> FleetConfigurationFleetAssetId3Navigations { get; set; }
        public virtual ICollection<FleetConfiguration> FleetConfigurationFleetAssetId4Navigations { get; set; }
        public virtual ICollection<FleetConfiguration> FleetConfigurationFleetAssets { get; set; }
        public virtual ICollection<OdometerReading> OdometerReadings { get; set; }
    }
}
