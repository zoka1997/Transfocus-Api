using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ServiceCodeProduct
    {
        public Guid Id { get; set; }
        public Guid ServiceCodeId { get; set; }
        public Guid ProductId { get; set; }
        public Guid CustomerId { get; set; }

        public virtual Customer Customer { get; set; } = null!;
        public virtual Product Product { get; set; } = null!;
        public virtual ServiceCode ServiceCode { get; set; } = null!;
    }
}
