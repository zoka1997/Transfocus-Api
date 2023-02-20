using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobSenderRecipientDefault
    {
        public Guid Id { get; set; }
        public Guid SenderId { get; set; }
        public Guid RecipientId { get; set; }
        public Guid? DefaultCustomerId { get; set; }
        public decimal? DefaultHours { get; set; }
        public decimal? DefaultDistance { get; set; }
        public decimal? GoogleDistance { get; set; }
        public int? DefaultPayer { get; set; }
        public Guid CompanyId { get; set; }
        public string CreatedBy { get; set; } = null!;
        public DateTime CreatedDate { get; set; }
        public string? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Customer? DefaultCustomer { get; set; }
        public virtual Location Recipient { get; set; } = null!;
        public virtual Location Sender { get; set; } = null!;
    }
}
