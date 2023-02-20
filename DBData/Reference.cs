using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Reference
    {
        public Guid Id { get; set; }
        public Guid ReferenceTypeId { get; set; }
        public Guid TableId { get; set; }
        public string RefValue { get; set; } = null!;

        public virtual ReferenceType ReferenceType { get; set; } = null!;
        public virtual Job Table { get; set; } = null!;
    }
}
