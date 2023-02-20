using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomPage
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string Name { get; set; } = null!;
        public string Text { get; set; } = null!;
        public string ModifiedBy { get; set; } = null!;
        public DateTime Timestamp { get; set; }
        public int OrderNumber { get; set; }
        public string Color { get; set; } = null!;
        public bool IsReport { get; set; }
        public string? Reference1 { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual WebPanelUser ModifiedByNavigation { get; set; } = null!;
    }
}
