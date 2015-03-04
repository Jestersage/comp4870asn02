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

        

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.AbuserRelationship> AbuserRelationships { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Age> Ages { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.AssignedWorker> AssignedWorkers { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Crisis> Crises { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.DuplicateFile> DuplicateFiles { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Ethnicity> Ethnicities { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.FamilyViolenceFile> FamilyViolenceFiles { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Incident> Incidents { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.FileStatus> FileStatus { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.FiscalYear> FiscalYears { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Program> Programs { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.ReferralContact> ReferralContacts { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.ReferralSource> ReferralSources { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.RepeatClient> RepeatClients { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.RiskLevel> RiskLevels { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.RiskStatus> RiskStatus { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Service> Services { get; set; }

        public System.Data.Entity.DbSet<GoodSamaritan.Models.Client.Victim> Victims { get; set; }

        


    }
}