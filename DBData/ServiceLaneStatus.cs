using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ServiceLaneStatus
    {
        public ServiceLaneStatus()
        {
            ServiceLanes = new HashSet<ServiceLane>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;

        public virtual ICollection<ServiceLane> ServiceLanes { get; set; }
    }
}
