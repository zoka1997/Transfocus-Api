using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Counter
    {
        public string Key { get; set; } = null!;
        public int Value { get; set; }
        public DateTime? ExpireAt { get; set; }
    }
}
