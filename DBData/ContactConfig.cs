using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ContactConfig
    {
        public int Id { get; set; }
        public Guid ContactId { get; set; }
        public int SettingId { get; set; }
        public bool Value { get; set; }

        public virtual Contact Contact { get; set; } = null!;
        public virtual ContactSetting Setting { get; set; } = null!;
    }
}
