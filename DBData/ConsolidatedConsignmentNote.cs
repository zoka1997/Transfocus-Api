using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ConsolidatedConsignmentNote
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string Number { get; set; } = null!;
        public DateTime Date { get; set; }
        public Guid CustomerId { get; set; }
        public Guid? ReceiverId { get; set; }
        public Guid? DepotId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual Customer Customer { get; set; } = null!;
        public virtual Location? Depot { get; set; }
        public virtual Location? Receiver { get; set; }
    }
}
