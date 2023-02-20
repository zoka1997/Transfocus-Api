using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Export
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string ExportTypeId { get; set; } = null!;
        public string Url { get; set; } = null!;

        public virtual ExportType ExportType { get; set; } = null!;
        public virtual JobLeg JobLeg { get; set; } = null!;
    }
}
