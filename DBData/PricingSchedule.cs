using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class PricingSchedule
    {
        public PricingSchedule()
        {
            PricingScheduleCustomers = new HashSet<PricingScheduleCustomer>();
            ServiceLanes = new HashSet<ServiceLane>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string PricingScheduleStatusId { get; set; } = null!;
        public int Type { get; set; }
        public string Name { get; set; } = null!;
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public Guid? PricingScheduleTypeId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual PricingScheduleStatus PricingScheduleStatus { get; set; } = null!;
        public virtual PricingScheduleType? PricingScheduleType { get; set; }
        public virtual ICollection<PricingScheduleCustomer> PricingScheduleCustomers { get; set; }
        public virtual ICollection<ServiceLane> ServiceLanes { get; set; }
    }
}
