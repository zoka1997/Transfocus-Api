using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ImportedContactsForUpdate
    {
        public int Id { get; set; }
        public Guid? ContactId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? Phone { get; set; }
        public string? Mobile { get; set; }
        public string? Email { get; set; }
        public string? Salutation { get; set; }
        public bool? Active { get; set; }
        public string? TypeId { get; set; }
        public Guid? CompanyId { get; set; }
        public bool IsUser { get; set; }
        public string? Note { get; set; }
        public string? UserId { get; set; }
    }
}
