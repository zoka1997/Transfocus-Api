using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class RevokedManifestJobLeg
    {
        public Guid Id { get; set; }
        public Guid ManifestId { get; set; }
        public Guid JobLegId { get; set; }

        public virtual JobLeg JobLeg { get; set; } = null!;
        public virtual Manifest Manifest { get; set; } = null!;
    }
}
