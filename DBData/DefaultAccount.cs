using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class DefaultAccount
    {
        public DefaultAccount()
        {
            PaymentSalesLedgers = new HashSet<PaymentSalesLedger>();
        }

        public Guid Id { get; set; }
        public string? Code { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? FinancialStatementType { get; set; }
        public Guid CompanyId { get; set; }
        public bool IsDefault { get; set; }
        public bool IsBank { get; set; }
        public string? Glcode { get; set; }
        public string? CostCenter { get; set; }

        public virtual ICollection<PaymentSalesLedger> PaymentSalesLedgers { get; set; }
    }
}
