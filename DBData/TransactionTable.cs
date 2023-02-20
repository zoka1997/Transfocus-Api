using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class TransactionTable
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public Guid ObjectId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string Reference { get; set; } = null!;
        public string Description { get; set; } = null!;
        public Guid DefaultAccountId { get; set; }
        public decimal Debit { get; set; }
        public decimal Credit { get; set; }
        public decimal Amount { get; set; }
        public string AccountName { get; set; } = null!;

        public virtual Company Company { get; set; } = null!;
    }
}
