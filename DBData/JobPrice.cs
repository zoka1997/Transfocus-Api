using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobPrice
    {
        public Guid Id { get; set; }
        public Guid? JobId { get; set; }
        public decimal Rate { get; set; }
        public decimal Nett { get; set; }
        public decimal Gst { get; set; }
        public decimal Gross { get; set; }
        public string FoxProJobNumber { get; set; } = null!;
        public string? Description { get; set; }
        public int ItemNumber { get; set; }

        public virtual Job? Job { get; set; }
    }
}
