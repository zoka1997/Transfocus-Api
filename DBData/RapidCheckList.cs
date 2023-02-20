using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RapidCheckList
    {
        public Guid Id { get; set; }
        public bool? Answer01 { get; set; }
        public int? Answer02 { get; set; }
        public int? Answer03 { get; set; }
        public bool? Answer04 { get; set; }
        public bool? Answer05 { get; set; }
        public bool? Answer06 { get; set; }
        public string? Answer06Details { get; set; }
        public bool? Answer07 { get; set; }
        public string? Answer07Details { get; set; }
        public bool? FitForWork { get; set; }
        public DateTime? NotFitForWorkUntil { get; set; }
        public Guid AuthToken { get; set; }

        public virtual AuthToken AuthTokenNavigation { get; set; } = null!;
    }
}
