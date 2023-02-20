using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class InterfaceVersion
    {
        public InterfaceVersion()
        {
            Companies = new HashSet<Company>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? InterfaceTypeId { get; set; }
        public string? AccountingSystemId { get; set; }

        public virtual AccountingSystem? AccountingSystem { get; set; }
        public virtual InterfaceType? InterfaceType { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
    }
}
