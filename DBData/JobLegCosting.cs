using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegCosting
    {
        public Guid Id { get; set; }
        public Guid? JobLegId { get; set; }
        public Guid CostItemId { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitRate { get; set; }
        public decimal Amount { get; set; }
        public Guid? GstcodeId { get; set; }
        public decimal TaxRate { get; set; }
        public string? ChargeUnitId { get; set; }
        public string? Description { get; set; }
        public int? OrderNumber { get; set; }
        public bool ApplyFuelLevy { get; set; }
        public bool ReportSummaryInvoice { get; set; }
        public DateTime ModifiedOn { get; set; }
        public string ModifiedBy { get; set; } = null!;
        public string Status { get; set; } = null!;
        public Guid? ManifestId { get; set; }

        public virtual Pricing CostItem { get; set; } = null!;
        public virtual JobLeg? JobLeg { get; set; }
        public virtual Manifest? Manifest { get; set; }
    }
}
