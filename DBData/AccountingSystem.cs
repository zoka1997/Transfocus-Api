using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class AccountingSystem
    {
        public AccountingSystem()
        {
            AccountingSystemInstances = new HashSet<AccountingSystemInstance>();
            AccountingSystemInterfaceTypes = new HashSet<AccountingSystemInterfaceType>();
            Companies = new HashSet<Company>();
            InterfaceVersions = new HashSet<InterfaceVersion>();
            InvoicingUitexts = new HashSet<InvoicingUitext>();
            PanelInvoiceStatusNames = new HashSet<PanelInvoiceStatusName>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<AccountingSystemInstance> AccountingSystemInstances { get; set; }
        public virtual ICollection<AccountingSystemInterfaceType> AccountingSystemInterfaceTypes { get; set; }
        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<InterfaceVersion> InterfaceVersions { get; set; }
        public virtual ICollection<InvoicingUitext> InvoicingUitexts { get; set; }
        public virtual ICollection<PanelInvoiceStatusName> PanelInvoiceStatusNames { get; set; }
    }
}
