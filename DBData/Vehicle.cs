using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            JobLegTrailer1s = new HashSet<JobLeg>();
            JobLegTrailer2s = new HashSet<JobLeg>();
            JobLegVehicles = new HashSet<JobLeg>();
            ManifestTrailer1s = new HashSet<Manifest>();
            ManifestTrailer2s = new HashSet<Manifest>();
            ManifestVehicles = new HashSet<Manifest>();
            MassManagementTrailer1s = new HashSet<MassManagement>();
            MassManagementTrailer2s = new HashSet<MassManagement>();
            MassManagementVehicles = new HashSet<MassManagement>();
            UserDefaultTrailer1s = new HashSet<User>();
            UserDefaultTrailer2s = new HashSet<User>();
            UserDefaultVehicles = new HashSet<User>();
        }

        public Guid Id { get; set; }
        public string Code { get; set; } = null!;
        public string Name { get; set; } = null!;
        public string? Description { get; set; }
        public bool? Active { get; set; }
        public Guid CompanyId { get; set; }
        public string VehicleTypeId { get; set; } = null!;
        public Guid? LocationId { get; set; }
        public string? RegistrationNumber { get; set; }
        public bool ExportedToFoxPro { get; set; }
        public Guid? JobCodeId { get; set; }

        public virtual Company Company { get; set; } = null!;
        public virtual JobCode? JobCode { get; set; }
        public virtual Location? Location { get; set; }
        public virtual VehicleType VehicleType { get; set; } = null!;
        public virtual ICollection<JobLeg> JobLegTrailer1s { get; set; }
        public virtual ICollection<JobLeg> JobLegTrailer2s { get; set; }
        public virtual ICollection<JobLeg> JobLegVehicles { get; set; }
        public virtual ICollection<Manifest> ManifestTrailer1s { get; set; }
        public virtual ICollection<Manifest> ManifestTrailer2s { get; set; }
        public virtual ICollection<Manifest> ManifestVehicles { get; set; }
        public virtual ICollection<MassManagement> MassManagementTrailer1s { get; set; }
        public virtual ICollection<MassManagement> MassManagementTrailer2s { get; set; }
        public virtual ICollection<MassManagement> MassManagementVehicles { get; set; }
        public virtual ICollection<User> UserDefaultTrailer1s { get; set; }
        public virtual ICollection<User> UserDefaultTrailer2s { get; set; }
        public virtual ICollection<User> UserDefaultVehicles { get; set; }
    }
}
