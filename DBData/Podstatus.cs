using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Podstatus
    {
        public Podstatus()
        {
            JobLegs = new HashSet<JobLeg>();
            Podexceptions = new HashSet<Podexception>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Podexception> Podexceptions { get; set; }
    }
}
