using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SuburbDistanceConfigView
    {
        public Guid Id { get; set; }
        public string From { get; set; } = null!;
        public string NameFrom { get; set; } = null!;
        public string StateIdfrom { get; set; } = null!;
        public int PostcodeFrom { get; set; }
        public string To { get; set; } = null!;
        public string NameTo { get; set; } = null!;
        public string StateIdto { get; set; } = null!;
        public int PostcodeTo { get; set; }
        public decimal? Kilometers { get; set; }
        public decimal? Hours { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
