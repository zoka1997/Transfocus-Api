using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AvailableServiceCode
    {
        public Guid Id { get; set; }
        public Guid? ServiceCodeId { get; set; }
        public string? ClientId { get; set; }

        public virtual ServiceCode? ServiceCode { get; set; }
    }
}
