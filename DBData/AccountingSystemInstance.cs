using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AccountingSystemInstance
    {
        public AccountingSystemInstance()
        {
            Customers = new HashSet<Customer>();
            PanelInvoices = new HashSet<PanelInvoice>();
            Subcontractors = new HashSet<Subcontractor>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string SystemId { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? XeroAccessToken { get; set; }
        public DateTime? LastSyncDate { get; set; }
        public string? XeroTenantId { get; set; }
        public string? XeroRefreshToken { get; set; }
        public DateTime? XeroExpiresAtUtc { get; set; }
        public DateTime? LastSubcontractorSyncDate { get; set; }
        public DateTime? LastInvoiceSyncDate { get; set; }
        public DateTime? LastPricingsSyncDate { get; set; }
        public DateTime? LastSubcontractorInvoiceSyncDate { get; set; }
        public DateTime? LastCostingSyncDate { get; set; }
        public string? BusinessName { get; set; }
        public string? PostalAddress { get; set; }
        public string? Abn { get; set; }
        public string? Phone { get; set; }
        public string? Fax { get; set; }
        public string? Email { get; set; }
        public string? EntityLogo { get; set; }
        public string? BankDetails { get; set; }
        public bool? Active { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual AccountingSystem System { get; set; } = null!;
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<PanelInvoice> PanelInvoices { get; set; }
        public virtual ICollection<Subcontractor> Subcontractors { get; set; }
    }
}
