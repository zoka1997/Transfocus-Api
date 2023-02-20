using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobImportType
    {
        public JobImportType()
        {
            Jobs = new HashSet<Job>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<Job> Jobs { get; set; }
    }
}
