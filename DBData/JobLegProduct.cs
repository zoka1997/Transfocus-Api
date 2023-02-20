using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegProduct
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public Guid ProductId { get; set; }
        public string? Barcode { get; set; }
        public decimal Quantity { get; set; }
        public decimal Pallet { get; set; }
        public decimal? Cubic { get; set; }
        public decimal? Weight { get; set; }
        public string? Description { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Depth { get; set; }
        public DateTime? TimestampScanLoad { get; set; }
        public bool ScannedLoad { get; set; }
        public DateTime? TimestampScanOff { get; set; }
        public bool ScannedOff { get; set; }
        public string? Code { get; set; }
        public decimal? Space { get; set; }
        public decimal? Hooks { get; set; }
        public decimal? Ties { get; set; }
        public string? Temp { get; set; }
        public string? PalletTypeId { get; set; }
        public decimal? CustomField01 { get; set; }
        public decimal? CustomField02 { get; set; }
        public decimal? CustomField03 { get; set; }
        public decimal? CustomField04 { get; set; }
        public decimal? CustomField05 { get; set; }
        public string? ShippingUnit { get; set; }
        public string? Reference { get; set; }
        public bool IsLegProduct { get; set; }
        public bool EdiStatusTimestampScanLoad { get; set; }
        public bool EdiStatusTimestampScanOff { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual PalletType? PalletType { get; set; }
        public virtual Product Product { get; set; } = null!;
    }
}
