using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class EmailSmstemplate
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string? Subject { get; set; }
        public string Body { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public Guid? CustomerId { get; set; }
        public string? UserName { get; set; }
    }
}
