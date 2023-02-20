using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ProductLocation
    {
        public Guid Id { get; set; }
        public Guid LocationId { get; set; }
        public Guid ProductId { get; set; }
        public Guid? CompanyId { get; set; }
        public bool? Active { get; set; }

        public virtual Company? Company { get; set; }
        public virtual Location Location { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
