using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Edipath
    {
        public string CompanyCode { get; set; } = null!;
        public string Path { get; set; } = null!;
        public int MillisecondsSinceLastWrite { get; set; }
        public int CheckTimeInterval { get; set; }
    }
}
