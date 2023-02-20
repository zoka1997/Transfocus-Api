using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class CustomActivity
    {
        public CustomActivity()
        {
            JobLegActivities = new HashSet<JobLegActivity>();
            JobLegCustomActivities = new HashSet<JobLegCustomActivity>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; } = null!;
        public string DataType { get; set; } = null!;
        public Guid? CustomerId { get; set; }
        public Guid? LocationId { get; set; }
        public string DisplayTime { get; set; } = null!;
        public Guid? CompanyId { get; set; }
        public string? Header { get; set; }
        public int? OrderNumber { get; set; }
        public string? DropdownItems { get; set; }
        public string? PricingCode { get; set; }
        public int? NumberOfPhotos { get; set; }
        public bool? Mandatory { get; set; }
        public bool? Active { get; set; }
        public Guid? PricingCodeId { get; set; }

        public virtual Customer? Customer { get; set; }
        public virtual Location? Location { get; set; }
        public virtual Pricing? PricingCodeNavigation { get; set; }
        public virtual ICollection<JobLegActivity> JobLegActivities { get; set; }
        public virtual ICollection<JobLegCustomActivity> JobLegCustomActivities { get; set; }
    }
}
