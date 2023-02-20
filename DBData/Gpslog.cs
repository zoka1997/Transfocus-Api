using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Gpslog
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public Guid AuthToken { get; set; }

        public virtual AuthToken AuthTokenNavigation { get; set; } = null!;
    }
}
