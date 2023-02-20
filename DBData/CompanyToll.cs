using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CompanyToll
    {
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public int GeneralTollsId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual GeneralToll GeneralTolls { get; set; } = null!;
    }
}
