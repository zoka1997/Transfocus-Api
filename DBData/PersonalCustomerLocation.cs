using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PersonalCustomerLocation
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public Guid LocationId { get; set; }
        public string PersonalLocationTypeId { get; set; } = null!;

        public virtual Customer Customer { get; set; } = null!;
        public virtual Location Location { get; set; } = null!;
        public virtual PersonalLocationType PersonalLocationType { get; set; } = null!;
    }
}
