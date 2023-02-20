using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Contact
    {
        public Contact()
        {
            ContactConfigs = new HashSet<ContactConfig>();
            ContactObjects = new HashSet<ContactObject>();
            ContactTypeDetails = new HashSet<ContactTypeDetail>();
            JobBookingContacts = new HashSet<Job>();
            JobReceiverContactNavigations = new HashSet<Job>();
            JobSenderContactNavigations = new HashSet<Job>();
        }

        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Email { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public bool Active { get; set; }
        public Guid? LocationId { get; set; }
        public string? TypeId { get; set; }
        public Guid CompanyId { get; set; }
        public string? Salutation { get; set; }
        public int? InvoiceTemplateId { get; set; }
        public bool UseInvoiceExport { get; set; }
        public Guid? ExportInvoiceTemplateId { get; set; }
        public string? Position { get; set; }
        public string? PhoneExtension { get; set; }
        public string? Note { get; set; }
        public bool IsUser { get; set; }
        public string? FullName { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Location? Location { get; set; }
        public virtual ContactType? Type { get; set; }
        public virtual ICollection<ContactConfig> ContactConfigs { get; set; }
        public virtual ICollection<ContactObject> ContactObjects { get; set; }
        public virtual ICollection<ContactTypeDetail> ContactTypeDetails { get; set; }
        public virtual ICollection<Job> JobBookingContacts { get; set; }
        public virtual ICollection<Job> JobReceiverContactNavigations { get; set; }
        public virtual ICollection<Job> JobSenderContactNavigations { get; set; }
    }
}
