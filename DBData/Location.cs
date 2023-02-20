using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Location
    {
        public Location()
        {
            Companies = new HashSet<Company>();
            ConsolidatedConsignmentNoteDepots = new HashSet<ConsolidatedConsignmentNote>();
            ConsolidatedConsignmentNoteReceivers = new HashSet<ConsolidatedConsignmentNote>();
            Contacts = new HashSet<Contact>();
            CustomActivities = new HashSet<CustomActivity>();
            CustomerLocations = new HashSet<CustomerLocation>();
            Customers = new HashSet<Customer>();
            FleetAssets = new HashSet<FleetAsset>();
            InverseDefaultDepot = new HashSet<Location>();
            JobDepots = new HashSet<Job>();
            JobLegDepots = new HashSet<JobLeg>();
            JobLegRecepients = new HashSet<JobLeg>();
            JobLegSenders = new HashSet<JobLeg>();
            JobRecipients = new HashSet<Job>();
            JobSenderRecipientDefaultRecipients = new HashSet<JobSenderRecipientDefault>();
            JobSenderRecipientDefaultSenders = new HashSet<JobSenderRecipientDefault>();
            JobSenders = new HashSet<Job>();
            LocationPolygons = new HashSet<LocationPolygon>();
            ManifestLinehaulManifestFromNavigations = new HashSet<Manifest>();
            ManifestLinehaulManifestToNavigations = new HashSet<Manifest>();
            OpeningHours = new HashSet<OpeningHour>();
            PalletAccounts = new HashSet<PalletAccount>();
            PalletAddressAccounts = new HashSet<PalletAddressAccount>();
            PersonalCustomerLocations = new HashSet<PersonalCustomerLocation>();
            ProductLocations = new HashSet<ProductLocation>();
            SubcontractorLocationZones = new HashSet<SubcontractorLocationZone>();
            Subcontractors = new HashSet<Subcontractor>();
            Users = new HashSet<User>();
            Vehicles = new HashSet<Vehicle>();
            WebPanelUsers = new HashSet<WebPanelUser>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string? PostCode { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Address { get; set; }
        public bool Active { get; set; }
        public string? Code { get; set; }
        public Guid CompanyId { get; set; }
        public Guid? CustomerId { get; set; }
        public string LocationTypeId { get; set; } = null!;
        public string? Phone { get; set; }
        public string? Note { get; set; }
        public string? Address2 { get; set; }
        public Guid? Suburb { get; set; }
        public Guid? ZoneId { get; set; }
        public Guid? PricingZoneId { get; set; }
        public Guid? CostingZoneId { get; set; }
        public bool IsApproved { get; set; }
        public int CountryId { get; set; }
        public string? Email { get; set; }
        public bool ReceiveEtaemail { get; set; }
        public bool ExportedToFoxPro { get; set; }
        public string? TypeNote { get; set; }
        public string? LocationUseTypeId { get; set; }
        public Guid? Group1Id { get; set; }
        public Guid? ParentId { get; set; }
        public string? Address3 { get; set; }
        public Guid? DepotZoneId { get; set; }
        public string? LocationPhoto { get; set; }
        public bool? AvailableForLeg { get; set; }
        public bool IsInternational { get; set; }
        public string? AddressFull { get; set; }
        public Guid? Group2Id { get; set; }
        public Guid? DefaultCustomerId { get; set; }
        public Guid? DefaultDepotId { get; set; }
        public string? Timezone { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Zone? CostingZone { get; set; }
        public virtual Country Country { get; set; } = null!;
        public virtual Customer? Customer { get; set; }
        public virtual Customer? DefaultCustomer { get; set; }
        public virtual Location? DefaultDepot { get; set; }
        public virtual Zone? DepotZone { get; set; }
        public virtual GenericGroup? Group1 { get; set; }
        public virtual GenericGroup? Group2 { get; set; }
        public virtual LocationType LocationType { get; set; } = null!;
        public virtual LocationUseType? LocationUseType { get; set; }
        public virtual Zone? PricingZone { get; set; }
        public virtual State? StateNavigation { get; set; }
        public virtual Suburb? SuburbNavigation { get; set; }
        public virtual Zone? Zone { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<ConsolidatedConsignmentNote> ConsolidatedConsignmentNoteDepots { get; set; }
        public virtual ICollection<ConsolidatedConsignmentNote> ConsolidatedConsignmentNoteReceivers { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<CustomActivity> CustomActivities { get; set; }
        public virtual ICollection<CustomerLocation> CustomerLocations { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<FleetAsset> FleetAssets { get; set; }
        public virtual ICollection<Location> InverseDefaultDepot { get; set; }
        public virtual ICollection<Job> JobDepots { get; set; }
        public virtual ICollection<JobLeg> JobLegDepots { get; set; }
        public virtual ICollection<JobLeg> JobLegRecepients { get; set; }
        public virtual ICollection<JobLeg> JobLegSenders { get; set; }
        public virtual ICollection<Job> JobRecipients { get; set; }
        public virtual ICollection<JobSenderRecipientDefault> JobSenderRecipientDefaultRecipients { get; set; }
        public virtual ICollection<JobSenderRecipientDefault> JobSenderRecipientDefaultSenders { get; set; }
        public virtual ICollection<Job> JobSenders { get; set; }
        public virtual ICollection<LocationPolygon> LocationPolygons { get; set; }
        public virtual ICollection<Manifest> ManifestLinehaulManifestFromNavigations { get; set; }
        public virtual ICollection<Manifest> ManifestLinehaulManifestToNavigations { get; set; }
        public virtual ICollection<OpeningHour> OpeningHours { get; set; }
        public virtual ICollection<PalletAccount> PalletAccounts { get; set; }
        public virtual ICollection<PalletAddressAccount> PalletAddressAccounts { get; set; }
        public virtual ICollection<PersonalCustomerLocation> PersonalCustomerLocations { get; set; }
        public virtual ICollection<ProductLocation> ProductLocations { get; set; }
        public virtual ICollection<SubcontractorLocationZone> SubcontractorLocationZones { get; set; }
        public virtual ICollection<Subcontractor> Subcontractors { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<WebPanelUser> WebPanelUsers { get; set; }
    }
}
