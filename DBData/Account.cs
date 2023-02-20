using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Account
    {
        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string? Name { get; set; }
        public string? Type { get; set; }
        public Guid? CompanyId { get; set; }
    }
}
