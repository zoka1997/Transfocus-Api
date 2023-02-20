using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomerContact
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Name { get; set; } = null!;
        public string? Email { get; set; }
        public string Phone { get; set; } = null!;
        public bool IsPrimary { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public DateTime Timestamp { get; set; }

        public virtual Customer Customer { get; set; } = null!;
    }
}
