using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SuburbDistanceConfig
    {
        public Guid Id { get; set; }
        public string NameFrom { get; set; } = null!;
        public string StateIdfrom { get; set; } = null!;
        public int PostcodeFrom { get; set; }
        public string NameTo { get; set; } = null!;
        public string StateIdto { get; set; } = null!;
        public int PostcodeTo { get; set; }
        public decimal? Kilometers { get; set; }
        public decimal? Hours { get; set; }
        public Guid? CompanyId { get; set; }

        public virtual Company? Company { get; set; }
    }
}
