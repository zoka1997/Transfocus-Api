using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ViewTemplate
    {
        public ViewTemplate()
        {
            CompanyBookingScreenTemplates = new HashSet<Company>();
            CompanyBookingTemplates = new HashSet<Company>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string ViewRoute { get; set; } = null!;
        public string ViewType { get; set; } = null!;
        public string? ViewRoute1 { get; set; }

        public virtual ICollection<Company> CompanyBookingScreenTemplates { get; set; }
        public virtual ICollection<Company> CompanyBookingTemplates { get; set; }
    }
}
