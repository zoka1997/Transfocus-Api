using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Apikey
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string ApiKey1 { get; set; } = null!;
        public string Description { get; set; } = null!;
        public bool? Active { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
