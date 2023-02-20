using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Compliance
    {
        public Compliance()
        {
            CompanyCompliances = new HashSet<CompanyCompliance>();
        }

        public Guid Id { get; set; }
        public string ComplianceTypeId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public int? FleetAssetTypeId { get; set; }
        public int? FleetAssetSubtypeId { get; set; }
        public Guid CompanyId { get; set; }
        public bool Active { get; set; }
        public bool DisallowAllocation { get; set; }
        public bool NoWarningRequired { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual ComplianceType ComplianceType { get; set; } = null!;
        public virtual FleetAssetSubtype? FleetAssetSubtype { get; set; }
        public virtual FleetAssetType? FleetAssetType { get; set; }
        public virtual ICollection<CompanyCompliance> CompanyCompliances { get; set; }
    }
}
