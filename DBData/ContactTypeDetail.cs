using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ContactTypeDetail
    {
        public Guid Id { get; set; }
        public Guid ContactId { get; set; }
        public string TypeId { get; set; } = null!;

        public virtual Contact Contact { get; set; } = null!;
        public virtual ContactType Type { get; set; } = null!;
    }
}
