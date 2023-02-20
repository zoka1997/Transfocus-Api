using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EdilogDetail
    {
        public Guid Id { get; set; }
        public Guid EdilogId { get; set; }
        public string RowContent { get; set; } = null!;
        public string Message { get; set; } = null!;
        public bool Imported { get; set; }
        public bool AutoLegged { get; set; }
        public bool AutoManifested { get; set; }
        public string? JobNumber { get; set; }

        public virtual Edilog Edilog { get; set; } = null!;
    }
}
