using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class GridStateDefault
    {
        public Guid Id { get; set; }
        public string GridId { get; set; } = null!;
        public Guid GridProfileId { get; set; }
        public string WebPanelUserId { get; set; } = null!;
        public DateTime Timestamp { get; set; }

        public virtual GridStateProfile GridProfile { get; set; } = null!;
        public virtual WebPanelUser WebPanelUser { get; set; } = null!;
    }
}
