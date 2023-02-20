using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class WebPanelUserCustomer
    {
        public Guid Id { get; set; }
        public string? WebPanelUserId { get; set; }
        public Guid? CustomerId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual WebPanelUser? WebPanelUser { get; set; }
    }
}
