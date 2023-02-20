using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class DriverSignature
    {
        public Guid Id { get; set; }
        public DateTime TimeStamp { get; set; }
        public Guid AuthToken { get; set; }

        public virtual AuthToken AuthTokenNavigation { get; set; } = null!;
    }
}
