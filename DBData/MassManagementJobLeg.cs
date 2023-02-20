using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class MassManagementJobLeg
    {
        public Guid Id { get; set; }
        public Guid MassManagementId { get; set; }
        public Guid JobLegId { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual MassManagement MassManagement { get; set; } = null!;
    }
}
