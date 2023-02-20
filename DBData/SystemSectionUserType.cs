using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class SystemSectionUserType
    {
        public int Id { get; set; }
        public Guid SystemSectionId { get; set; }
        public int UserTypeId { get; set; }

        public virtual SystemSection SystemSection { get; set; } = null!;
        public virtual WebPanelUsersType UserType { get; set; } = null!;
    }
}
