using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ManifestStatus
    {
        public ManifestStatus()
        {
            ManifestHistories = new HashSet<ManifestHistory>();
            Manifests = new HashSet<Manifest>();
        }

        public string Id { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Color { get; set; }

        public virtual ICollection<ManifestHistory> ManifestHistories { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
    }
}
