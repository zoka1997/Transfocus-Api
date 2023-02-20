using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PalletTransaction
    {
        public Guid Id { get; set; }
        public int MovementNumber { get; set; }
        public int MovementType { get; set; }
        public Guid CompanyId { get; set; }
        public string PalletType { get; set; } = null!;
        public int Quantity { get; set; }
        public DateTime Timestamp { get; set; }
        public DateTime MovementDate { get; set; }
        public DateTime EffectiveDate { get; set; }
        public int DocketNumber { get; set; }
        public Guid? JobLegId { get; set; }
        public int Status { get; set; }
        public Guid? From { get; set; }
        public Guid? To { get; set; }
        public string? Reference { get; set; }
        public string Type { get; set; } = null!;

        public virtual JobLeg? JobLeg { get; set; }
        public virtual PalletMovementType MovementTypeNavigation { get; set; } = null!;
        public virtual PalletType PalletTypeNavigation { get; set; } = null!;
    }
}
