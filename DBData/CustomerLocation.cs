using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomerLocation
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Customer Customer { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
    }
}
