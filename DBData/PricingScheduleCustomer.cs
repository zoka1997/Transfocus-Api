using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingScheduleCustomer
    {
        public Guid Id { get; set; }
        public Guid PricingScheduleId { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual PricingSchedule PricingSchedule { get; set; } = null!;
    }
}
