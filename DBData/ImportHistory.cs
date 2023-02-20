using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ImportHistory
    {
        public Guid Id { get; set; }
        public string? ListOfIds { get; set; }
        public DateTime? Timestamp { get; set; }
        public string? ImportedFrom { get; set; }
    }
}
