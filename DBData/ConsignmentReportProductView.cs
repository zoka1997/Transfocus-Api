using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ConsignmentReportProductView
    {
        public string Name { get; set; } = null!;
        public string Code { get; set; } = null!;
        public bool ScannedOff { get; set; }
        public bool ScannedLoad { get; set; }
        public decimal Quantity { get; set; }
    }
}
