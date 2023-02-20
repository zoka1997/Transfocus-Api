using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CheckList
    {
        public CheckList()
        {
            CheckListsHistories = new HashSet<CheckListsHistory>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public bool? Active { get; set; }
        public Guid? CompanyId { get; set; }
        public bool Deleted { get; set; }
        public bool OppositeQuestion { get; set; }

        public virtual Company? Company { get; set; }
        public virtual ICollection<CheckListsHistory> CheckListsHistories { get; set; }
    }
}
