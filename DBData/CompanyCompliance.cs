using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CompanyCompliance
    {
        public Guid Id { get; set; }
        public Guid ComplianceId { get; set; }
        public string? Class { get; set; }
        public string? LicenceNo { get; set; }
        public DateTime? EffectiveDate { get; set; }
        public DateTime? ExpiryDate { get; set; }
        public string? Comment { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? FleetId { get; set; }
        public Guid? DriverId { get; set; }
        public Guid? SubcontractorId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Compliance Compliance { get; set; } = null!;
        public virtual User? Driver { get; set; }
        public virtual FleetAsset? Fleet { get; set; }
        public virtual Subcontractor? Subcontractor { get; set; }
    }
}
