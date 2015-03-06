namespace GoodSamaritan.Migrations.ClientMigrations
{
    using GoodSamaritan.Models.Client;
    using GoodSamaritan.Models.Smart;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodSamaritan.Models.Client.ClientContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\ClientMigrations";
        }

        protected override void Seed(GoodSamaritan.Models.Client.ClientContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Client> Clients = new List<Client>() {
              new Client { 
                ClientId= 1, 
                Month=9,
                Day=17,
                Surname="Doe",
                FirstName="John",
                },            
              };

            context.Clients.AddOrUpdate(
                c => c.ClientId,
                Clients.ToArray()
            );

            List<FiscalYear> FiscalYears = new List<FiscalYear>() {
                new FiscalYear { 
                  //10-11; 11-12; 12-13; 13-14; 14-15; 15-16; 16-17
                FiscalYearName="10-11",
                },
                new FiscalYear { 
                  //10-11; 11-12; 12-13; 13-14; 14-15; 15-16; 16-17
                FiscalYearName="11-12",
                },
                new FiscalYear { 
                  //10-11; 11-12; 12-13; 13-14; 14-15; 15-16; 16-17
                FiscalYearName="12-13",
                },
              };

            context.FiscalYears.AddOrUpdate(
                f => f.FiscalYearId,
                FiscalYears.ToArray()
            );


            context.RiskLevels.AddOrUpdate(
                  risk => risk.RiskLevelValue,
                  new RiskLevel { RiskLevelValue = "High" },
                  new RiskLevel { RiskLevelValue = "DVU" },
                  new RiskLevel { RiskLevelValue = "NULL" }
            );

            context.Crises.AddOrUpdate(
                  cri => cri.CrisisName,
                  new Crisis { CrisisName = "Call" },
                  new Crisis { CrisisName = "Accompaniment" },
                  new Crisis { CrisisName = "Drop-in" }
            );

            context.Services.AddOrUpdate(
                  ser => ser.ServiceName,
                  new Service { ServiceName = "File" },
                  new Service { ServiceName = "N/A" }
            );

            context.Programs.AddOrUpdate(
                  pro => pro.ProgramName,
                  new Program { ProgramName = "File" },
                  new Program { ProgramName = "N/A" }
            );

            context.RiskStatus.AddOrUpdate(
                  risks => risks.RiskStatusValue,
                  new RiskStatus { RiskStatusValue = "File" },
                  new RiskStatus { RiskStatusValue = "N/A" }
            );

            //Michelle; Tyra; Louise; Angela; Dave; Troy; Michael; Manpreet; Patrick; None
            context.AssignedWorkers.AddOrUpdate(
                  aw => aw.Name,
                  new AssignedWorker { Name = "Michelle" },
                  new AssignedWorker { Name = "Tyra" },
                  new AssignedWorker { Name = "Louise" },
                  new AssignedWorker { Name = "Angela" },
                  new AssignedWorker { Name = "Dave" },
                  new AssignedWorker { Name = "Troy" },
                  new AssignedWorker { Name = "Michael" },
                  new AssignedWorker { Name = "Manpreet" },
                  new AssignedWorker { Name = "Patrick" },
                  new AssignedWorker { Name = "None" }
            );

            //Community Agency; Family/Friend; Government; CVAP; CBVS
            context.ReferralSources.AddOrUpdate(
                  refs => refs.Source,
                  new ReferralSource { Source = "Community Agency" },
                  new ReferralSource { Source = "Family/Friend" },
                  new ReferralSource { Source = "Government" },
                  new ReferralSource { Source = "CVAP" },
                  new ReferralSource { Source = "CBVS" }
            );

            context.ReferralContacts.AddOrUpdate(
                  refc => refc.ReferralContactName,
                  new ReferralContact { ReferralContactName = "PBVS" },
                  new ReferralContact { ReferralContactName = "MCFD" },
                  new ReferralContact { ReferralContactName = "PBVS" },
                  new ReferralContact { ReferralContactName = "VictimLINK" },
                  new ReferralContact { ReferralContactName = "TH" },
                  new ReferralContact { ReferralContactName = "Self" },
                  new ReferralContact { ReferralContactName = "FNS" },
                  new ReferralContact { ReferralContactName = "Other" },
                  new ReferralContact { ReferralContactName = "Medical" }
            );

            //SMART
            context.BadDateReports.AddOrUpdate(
                  bd => bd.Value,
                  new BadDateReport { Value = "Yes" },
                  new BadDateReport { Value = "No" },
                  new BadDateReport { Value = "N/A" }
            );

            //Abduction; Adult Historical Sexual Assault; Adult Sexual Assault;
            //Partner Assault; Attempted Murder; Child Physical Assault;\
            //Child Sexual Abuse/Exploitation; Criminal Harassment/Stalking;
            //Elder Abuse; Human Trafficking; Murder; N/A; Other; Other Assault;
            //Other Crime – DV; Other Familial Assault; Threatening;
            //Youth Sexual Assault/Exploitation
            context.Incidents.AddOrUpdate(
                  inci => inci.Type,
                  new Incident { Type = "Abduction" },
                  new Incident { Type = "Adult Historical Sexual Assault" },
                  new Incident { Type = "Adult Sexual Assault" },
                  new Incident { Type = "Partner Assault" },
                  new Incident { Type = "Attempted Murder" },
                  new Incident { Type = "Child Physical Assault" },
                  new Incident { Type = "Child Sexual Abuse/Exploitation" },
                  new Incident { Type = "Murder" },
                  new Incident { Type = "N/A" },
                  new Incident { Type = "Other" },
                  new Incident { Type = "Other Assault" },
                  new Incident { Type = "Other Crime – DV" },
                  new Incident { Type = "Other Familial Assault" },
                  new Incident { Type = "Threatening" },
                  new Incident { Type = "Youth Sexual Assault/Exploitation" }
            );

            //Acquaintance; Bad Date; DNA; Ex-Partner; Friend;
            //Multiple Perps; N/A; Other; Other Familial; Parent;
            //Partner; Sibling; Stranger
            context.AbuserRelationships.AddOrUpdate(
                  abuser => abuser.Type,
                  new AbuserRelationship { Type = "Acquaintance" },
                  new AbuserRelationship { Type = "Bad Date" },
                  new AbuserRelationship { Type = "DNA" },
                  new AbuserRelationship { Type = "Ex-Partner" },
                  new AbuserRelationship { Type = "Friend" },
                  new AbuserRelationship { Type = "Multiple Perps" },
                  new AbuserRelationship { Type = "N/A" },
                  new AbuserRelationship { Type = "Other" },
                  new AbuserRelationship { Type = "Other Familial" },
                  new AbuserRelationship { Type = "Parent" },
                  new AbuserRelationship { Type = "Partner" },
                  new AbuserRelationship { Type = "Sibling" },
                  new AbuserRelationship { Type = "Stranger" }
            );

            context.Victims.AddOrUpdate(
                 vic => vic.Type,
                 new Victim { Type = "Primary" },
                 new Victim { Type = "Secondary" }
           );

            context.FamilyViolenceFiles.AddOrUpdate(
                 fvf => fvf.Status,
                 new FamilyViolenceFile { Status = "Yes" },
                 new FamilyViolenceFile { Status = "No" },
                 new FamilyViolenceFile { Status = "N/A" }
            );

            //Indigenous; Asian; Black; Caucasian; Declined;
            //Latin; Middle Eastern; Other; South Asian; South East Asian
            context.Ethnicities.AddOrUpdate(
                 eth => eth.Ethnictiy,
                 new Ethnicity { Ethnictiy = "Indigenous" },
                 new Ethnicity { Ethnictiy = "Asian" },
                 new Ethnicity { Ethnictiy = "Black" },
                 new Ethnicity { Ethnictiy = "Caucasian" },
                 new Ethnicity { Ethnictiy = "Declined" },
                 new Ethnicity { Ethnictiy = "Latin" },
                 new Ethnicity { Ethnictiy = "Middle Eastern" },
                 new Ethnicity { Ethnictiy = "Other" },
                 new Ethnicity { Ethnictiy = "South Asian" },
                 new Ethnicity { Ethnictiy = "South East Asian" }
            );

            //Adult >24 <65; Youth >12 <19; Youth >18 <25; Child<13; Senior >64
            context.Ages.AddOrUpdate(
                 ag => ag.AgeRange,
                 new Age { AgeRange = "Adult >24 <65" },
                 new Age { AgeRange = "Youth >18 <25" },
                 new Age { AgeRange = "Youth >12 <19" },
                 new Age { AgeRange = "Child<13" },
                 new Age { AgeRange = "Senior >64" }
            );
        }
    }
}
