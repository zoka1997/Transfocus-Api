using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomerProduct
    {
        public Guid Id { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
    }
}
