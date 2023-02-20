using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ContactSetting
    {
        public ContactSetting()
        {
            ContactConfigs = new HashSet<ContactConfig>();
        }

        public int Id { get; set; }
        public string TypeId { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ContactType Type { get; set; } = null!;
        public virtual ICollection<ContactConfig> ContactConfigs { get; set; }
    }
}
