using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class UserType
    {
        public UserType()
        {
            Users = new HashSet<User>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<User> Users { get; set; }
    }
}
