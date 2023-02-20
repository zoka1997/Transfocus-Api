using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ImportType
    {
        public ImportType()
        {
            AutomaticEdilogs = new HashSet<AutomaticEdilog>();
        }

        public int Id { get; set; }
        public string? Name { get; set; }

        public virtual ICollection<AutomaticEdilog> AutomaticEdilogs { get; set; }
    }
}
