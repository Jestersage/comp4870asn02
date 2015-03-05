using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class ClientContext:DbContext
    {
        public ClientContext() : base("DefaultConnection")
        { Database.SetInitializer(new DropCreateDatabaseAlways<ClientContext>()); }
        public DbSet<Client> Clients{get; set;}

        public DbSet<AbuserRelationship> AbuserRelationships { get; set; }

        public DbSet<Age> Ages { get; set; }

        public DbSet<AssignedWorker> AssignedWorkers { get; set; }

        public DbSet<Crisis> Crises { get; set; }

        public DbSet<DuplicateFile> DuplicateFiles { get; set; }

        public DbSet<Ethnicity> Ethnicities { get; set; }

        public DbSet<FamilyViolenceFile> FamilyViolenceFiles { get; set; }

        public DbSet<Incident> Incidents { get; set; }

        public DbSet<FileStatus> FileStatus { get; set; }

        public DbSet<FiscalYear> FiscalYears { get; set; }

        public DbSet<Program> Programs { get; set; }

        public DbSet<ReferralContact> ReferralContacts { get; set; }

        public DbSet<ReferralSource> ReferralSources { get; set; }

        public DbSet<RepeatClient> RepeatClients { get; set; }

        public DbSet<RiskLevel> RiskLevels { get; set; }

        public DbSet<RiskStatus> RiskStatus { get; set; }

        public DbSet<Service> Services { get; set; }

        public DbSet<Victim> Victims { get; set; }

        


    }
}