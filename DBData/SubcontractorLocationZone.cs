using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SubcontractorLocationZone
    {
        public Guid Id { get; set; }
        public Guid SubcontractorId { get; set; }
        public Guid? LocationId { get; set; }
        public Guid? SuburbId { get; set; }
        public Guid ZoneId { get; set; }

        public virtual Location? Location { get; set; }
        public virtual Subcontractor Subcontractor { get; set; } = null!;
        public virtual Suburb? Suburb { get; set; }
        public virtual Zone Zone { get; set; } = null!;
    }
}
