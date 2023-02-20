using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobProductHistory
    {
        public Guid Id { get; set; }
        public Guid JobId { get; set; }
        public DateTime TimeStamp { get; set; }
        public string? Username { get; set; }
        public string? IpAddress { get; set; }
        public string? Description { get; set; }
        public string? JobProduct { get; set; }
        public string? ChangeDescription { get; set; }
        public DateTime? TimeStampUtc { get; set; }
    }
}
