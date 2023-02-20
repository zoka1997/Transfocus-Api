using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomerPricingNote
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public string Note { get; set; } = null!;
        public string UserId { get; set; } = null!;
        public string Ipaddress { get; set; } = null!;
        public DateTime Timestamp { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual WebPanelUser User { get; set; } = null!;
    }
}
