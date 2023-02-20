using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class ManifestType
    {
        public ManifestType()
        {
            Manifests = new HashSet<Manifest>();
        }

        public string Code { get; set; } = null!;
        public string? Name { get; set; }

        public virtual ICollection<Manifest> Manifests { get; set; }
    }
}
