using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobSource
    {
        public JobSource()
        {
            Companies = new HashSet<Company>();
            Jobs = new HashSet<Job>();
        }

        public int Id { get; set; }
        public string Name { get; set; } = null!;

        public virtual ICollection<Company> Companies { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
    }
}
