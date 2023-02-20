using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Subcontractor
    {
        public Subcontractor()
        {
            CompanyCompliances = new HashSet<CompanyCompliance>();
            CostingSchedules = new HashSet<CostingSchedule>();
            ExternalJobStatuses = new HashSet<ExternalJobStatus>();
            FleetAssets = new HashSet<FleetAsset>();
            PanelInvoices = new HashSet<PanelInvoice>();
            Pricings = new HashSet<Pricing>();
            SubcontractorLocationZones = new HashSet<SubcontractorLocationZone>();
            SubcontractorPayments = new HashSet<SubcontractorPayment>();
            Users = new HashSet<User>();
            WebPanelUsers = new HashSet<WebPanelUser>();
            Zones = new HashSet<Zone>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public Guid CompanyId { get; set; }
        public string? Address { get; set; }
        public string? Telephone { get; set; }
        public string? Username { get; set; }
        public bool? Active { get; set; }
        public int CountryId { get; set; }
        public Guid? AccoutingSystemInstanceId { get; set; }
        public string? AccountingSystemId { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public string? PaymentTermsId { get; set; }
        public bool PaymentTermsEop { get; set; }
        public Guid? PostalLocationId { get; set; }
        public string? Abn { get; set; }
        public bool Gstregistered { get; set; }
        public bool NotUseSubCostZones { get; set; }

        public virtual AccountingSystemInstance? AccoutingSystemInstance { get; set; }
        public virtual Company Company { get; set; } = null!;
        public virtual Country Country { get; set; } = null!;
        public virtual PaymentTerm? PaymentTerms { get; set; }
        public virtual Location? PostalLocation { get; set; }
        public virtual ICollection<CompanyCompliance> CompanyCompliances { get; set; }
        public virtual ICollection<CostingSchedule> CostingSchedules { get; set; }
        public virtual ICollection<ExternalJobStatus> ExternalJobStatuses { get; set; }
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
        public virtual ICollection<Pricing> Pricings { get; set; }
        public virtual ICollection<SubcontractorLocationZone> SubcontractorLocationZones { get; set; }
        public virtual ICollection<SubcontractorPayment> SubcontractorPayments { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<WebPanelUser> WebPanelUsers { get; set; }
        public virtual ICollection<Zone> Zones { get; set; }
    }
}
