using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobLegPallet
    {
        public Guid Id { get; set; }
        public Guid JobLegId { get; set; }
        public string PalletTypeId { get; set; } = null!;
        public decimal? Quantity { get; set; }
        public decimal BookedQuantity { get; set; }
        public int MovementTypeId { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid? DriverId { get; set; }
        public string? WebPanelUserId { get; set; }
        public decimal PickedQuantity { get; set; }
        public decimal DeliveredQuantity { get; set; }

        public virtual User? Driver { get; set; }
        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual PalletMovementType MovementType { get; set; } = null!;
        public virtual PalletType PalletType { get; set; } = null!;
        public virtual WebPanelUser? WebPanelUser { get; set; }
    }
}
