using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class TempLocation
    {
        public string? Code { get; set; }
        public string? Zone { get; set; }
        public string? Name { get; set; }
        public string? Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Suburb { get; set; }
        public string? State { get; set; }
        public double? PostalCode { get; set; }
        public string? Phone { get; set; }
    }
}
