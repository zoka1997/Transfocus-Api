using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class FleetConfiguration
    {
        public FleetConfiguration()
        {
            JobLegs = new HashSet<JobLeg>();
            Manifests = new HashSet<Manifest>();
            Users = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public string? Name { get; set; }
        public Guid? FleetAssetId { get; set; }
        public Guid? FleetAssetId2 { get; set; }
        public Guid? FleetAssetId3 { get; set; }
        public Guid? FleetAssetId4 { get; set; }
        public string? AddedFrom { get; set; }

        public virtual FleetAsset? FleetAsset { get; set; }
        public virtual FleetAsset? FleetAssetId2Navigation { get; set; }
        public virtual FleetAsset? FleetAssetId3Navigation { get; set; }
        public virtual FleetAsset? FleetAssetId4Navigation { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
