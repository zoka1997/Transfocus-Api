using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CheckListsHistory
    {
        public Guid Id { get; set; }
        public int CheckListsId { get; set; }
        public bool IsChecked { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid AuthToken { get; set; }
        public string? Note { get; set; }

        public virtual CheckList CheckLists { get; set; } = null!;
    }
}
