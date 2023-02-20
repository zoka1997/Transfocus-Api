using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Tmsapi
    {
        public Guid AuthToken { get; set; }
        public Guid CompanyId { get; set; }
        public string ServerUrl { get; set; } = null!;
        public bool Active { get; set; }

        public virtual Company Company { get; set; } = null!;
    }
}
