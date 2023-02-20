using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomActivityProduct
    {
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public decimal? RetailPrice { get; set; }
        public Guid CompanyId { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
