using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ExportType
    {
        public ExportType()
        {
            Exports = new HashSet<Export>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Export> Exports { get; set; }
    }
}
