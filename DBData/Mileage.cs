using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Mileage
    {
        public string? OriginCity { get; set; }
        public string? OriginProvince { get; set; }
        public string? DestinationCity { get; set; }
        public string? DestinationProvin { get; set; }
        public double? Distance { get; set; }
        public double? FlatPayAmt { get; set; }
        public string? Source { get; set; }
        public string? RouteMode { get; set; }
        public double? Tolls { get; set; }
    }
}
