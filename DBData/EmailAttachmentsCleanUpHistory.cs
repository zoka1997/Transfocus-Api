using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EmailAttachmentsCleanUpHistory
    {
        public int Id { get; set; }
        public Guid CompanyId { get; set; }
        public DateTime? LastCleanUpDate { get; set; }
    }
}
