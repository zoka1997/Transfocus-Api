using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobImportMatch
    {
        public JobImportMatch()
        {
            JobImportModes = new HashSet<JobImportMode>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<JobImportMode> JobImportModes { get; set; }
    }
}
