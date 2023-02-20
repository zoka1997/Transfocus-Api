using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Log
    {
        public int Id { get; set; }
        public string? Message { get; set; }
        public string? MessageTemplate { get; set; }
        public string? Level { get; set; }
        public DateTimeOffset TimeStamp { get; set; }
        public string? Exception { get; set; }
        public string? Properties { get; set; }
        public string? LogEvent { get; set; }
        public string? StackTrace { get; set; }
        public string? Module { get; set; }
        public string? Token { get; set; }
        public string? UserName { get; set; }
        public string? CompanyCode { get; set; }
        public string? Ipaddress { get; set; }
        public string? Description { get; set; }
    }
}
