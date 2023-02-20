using System;
using System.Collections.Generic;

namespace TransfocusBack.DBData
{
    public partial class User
    {
        public User()
        {
            AuthTokens = new HashSet<AuthToken>();
            CompanyCompliances = new HashSet<CompanyCompliance>();
            ConversationParticipants = new HashSet<ConversationParticipant>();
            DeviceCrashLogs = new HashSet<DeviceCrashLog>();
            JobLegPallets = new HashSet<JobLegPallet>();
            JobLegs = new HashSet<JobLeg>();
            Jobs = new HashSet<Job>();
            Manifests = new HashSet<Manifest>();
            Messages = new HashSet<Message>();
            MessagingRecipients = new HashSet<Messaging>();
            MessagingSenders = new HashSet<Messaging>();
        }

        public Guid Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public int Pincode { get; set; }
        public string? Email { get; set; }
        public bool Active { get; set; }
        public string? Phone { get; set; }
        public Guid CompanyId { get; set; }
        public string? Code { get; set; }
        public string UserTypeId { get; set; } = null!;
        public Guid? DepotId { get; set; }
        public bool? UsesPodapp { get; set; }
        public Guid? DefaultVehicleId { get; set; }
        public Guid? DefaultTrailer1Id { get; set; }
        public Guid? DefaultTrailer2Id { get; set; }
        public Guid? AllocationZoneId { get; set; }
        public int CountryId { get; set; }
        public bool ExportedToFoxPro { get; set; }
        public bool DailyRunsheet { get; set; }
        public bool EmailConsignmentNoteOnDispatch { get; set; }
        public Guid? FleetConfigurationId { get; set; }
        public Guid? SubcontractorId { get; set; }
        public string? FullName { get; set; }
        public int? CostGroupId { get; set; }
        public bool UserWebapp { get; set; }
        public bool DispatchViaEmail { get; set; }
        public bool DispatchViaSms { get; set; }
        public bool CalculateProfitability { get; set; }

        public virtual Zone? AllocationZone { get; set; }
        public virtual Company Company { get; set; } = null!;
        public virtual CostGroup? CostGroup { get; set; }
        public virtual Country Country { get; set; } = null!;
        public virtual Vehicle? DefaultTrailer1 { get; set; }
        public virtual Vehicle? DefaultTrailer2 { get; set; }
        public virtual Vehicle? DefaultVehicle { get; set; }
        public virtual Location? Depot { get; set; }
        public virtual FleetConfiguration? FleetConfiguration { get; set; }
        public virtual Subcontractor? Subcontractor { get; set; }
        public virtual UserType UserType { get; set; } = null!;
        public virtual ICollection<AuthToken> AuthTokens { get; set; }
        public virtual ICollection<CompanyCompliance> CompanyCompliances { get; set; }
        public virtual ICollection<ConversationParticipant> ConversationParticipants { get; set; }
        public virtual ICollection<DeviceCrashLog> DeviceCrashLogs { get; set; }
        public virtual ICollection<JobLegPallet> JobLegPallets { get; set; }
        public virtual ICollection<JobLeg> JobLegs { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        public virtual ICollection<Manifest> Manifests { get; set; }
        public virtual ICollection<Message> Messages { get; set; }
        public virtual ICollection<Messaging> MessagingRecipients { get; set; }
        public virtual ICollection<Messaging> MessagingSenders { get; set; }
    }
}
