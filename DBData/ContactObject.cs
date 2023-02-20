using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ContactObject
    {
        public Guid ContactId { get; set; }
        public string ObjectId { get; set; } = null!;
        public int Id { get; set; }
        public string? TypeId { get; set; }

        public virtual Contact Contact { get; set; } = null!;
    }
}
