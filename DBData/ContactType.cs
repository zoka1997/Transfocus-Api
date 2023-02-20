using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ContactType
    {
        public ContactType()
        {
            ContactSettings = new HashSet<ContactSetting>();
            ContactTypeDetails = new HashSet<ContactTypeDetail>();
            Contacts = new HashSet<Contact>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<ContactSetting> ContactSettings { get; set; }
        public virtual ICollection<ContactTypeDetail> ContactTypeDetails { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
    }
}
