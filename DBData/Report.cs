using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Report
    {
        public Report()
        {
            CompanyConnoteTemplates = new HashSet<Company>();
            CompanyInvoiceTemplates = new HashSet<Company>();
            CompanyLabelTemplates = new HashSet<Company>();
            CompanyManifestReports = new HashSet<Company>();
            CompanyPodtemplates = new HashSet<Company>();
            Customers = new HashSet<Customer>();
            ReportCompanyLists = new HashSet<ReportCompanyList>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string SystemTypeName { get; set; } = null!;
        public string ReportType { get; set; } = null!;
        public bool IsDefaultForType { get; set; }
        public bool? IsCommon { get; set; }

        public virtual ICollection<Company> CompanyConnoteTemplates { get; set; }
        public virtual ICollection<Company> CompanyInvoiceTemplates { get; set; }
        public virtual ICollection<Company> CompanyLabelTemplates { get; set; }
        public virtual ICollection<Company> CompanyManifestReports { get; set; }
        public virtual ICollection<Company> CompanyPodtemplates { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<ReportCompanyList> ReportCompanyLists { get; set; }
    }
}
