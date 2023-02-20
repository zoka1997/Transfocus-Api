using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AccountingSystemInterfaceType
    {
        public int Id { get; set; }
        public string AccountingSystemId { get; set; } = null!;
        public string InterfaceTypeId { get; set; } = null!;

        public virtual AccountingSystem AccountingSystem { get; set; } = null!;
        public virtual InterfaceType InterfaceType { get; set; } = null!;
    }
}
