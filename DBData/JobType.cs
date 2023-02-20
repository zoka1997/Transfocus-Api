﻿using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class JobType
    {
        public JobType()
        {
            JobLegs = new HashSet<JobLeg>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<JobLeg> JobLegs { get; set; }
    }
}
