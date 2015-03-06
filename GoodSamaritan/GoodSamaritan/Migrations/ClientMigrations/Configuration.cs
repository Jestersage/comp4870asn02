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

            /*
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
             * */

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
            context.SaveChanges();

            context.RiskLevels.AddOrUpdate(
                  risk => risk.RiskLevelValue,
                  new RiskLevel { RiskLevelValue = "High" },
                  new RiskLevel { RiskLevelValue = "DVU" },
                  new RiskLevel { RiskLevelValue = "" }
            );
            context.SaveChanges();
            context.Crises.AddOrUpdate(
                  cri => cri.CrisisName,
                  new Crisis { CrisisName = "Call" },
                  new Crisis { CrisisName = "Accompaniment" },
                  new Crisis { CrisisName = "Drop-in" }
            );
            context.SaveChanges();

            context.Services.AddOrUpdate(
                  ser => ser.ServiceName,
                  new Service { ServiceName = "File" },
                  new Service { ServiceName = "N/A" }
            );
            context.SaveChanges();

            //Crisis; Court; SMART; DVU; MCFD
            context.Programs.AddOrUpdate(
                  pro => pro.ProgramName,
                  new Program { ProgramName = "Crisis" },
                  new Program { ProgramName = "Court" },
                  
                  new Program { ProgramName = "SMART" },
                  new Program { ProgramName = "DVU" },
                      
                  new Program { ProgramName = "MCFD" }
            );
            context.SaveChanges();

            context.RiskStatus.AddOrUpdate(
                  risks => risks.RiskStatusValue,
                  new RiskStatus { RiskStatusValue = "File" },
                  new RiskStatus { RiskStatusValue = "N/A" }
            );
            context.SaveChanges();

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
            context.SaveChanges();

            //Community Agency; Family/Friend; Government; CVAP; CBVS
            context.ReferralSources.AddOrUpdate(
                  refs => refs.Source,
                  new ReferralSource { Source = "Community Agency" },
                  new ReferralSource { Source = "Family/Friend" },
                  new ReferralSource { Source = "Government" },
                  new ReferralSource { Source = "CVAP" },
                  new ReferralSource { Source = "CBVS" }
            );
            context.SaveChanges();

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
            context.SaveChanges();
            
            //Abduction; Adult Historical Sexual Assault; Adult Sexual Assault;
            //Partner Assault; Attempted Murder; Child Physical Assault;\
            //Child Sexual Abuse/Exploitation; Criminal Harassment/Stalking;
            //Elder Abuse; Human Trafficking; Murder; N/A; Other; Other Assault;
            //Other Crime � DV; Other Familial Assault; Threatening;
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
                  new Incident { Type = "Other Crime � DV" },
                  new Incident { Type = "Other Familial Assault" },
                  new Incident { Type = "Threatening" },
                  new Incident { Type = "Youth Sexual Assault/Exploitation" }
            );
            context.SaveChanges();

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
            context.SaveChanges();

            context.Victims.AddOrUpdate(
                 vic => vic.Type,
                 new Victim { Type = "Primary" },
                 new Victim { Type = "Secondary" }
           );
            context.SaveChanges();

            context.FamilyViolenceFiles.AddOrUpdate(
                 fvf => fvf.Status,
                 new FamilyViolenceFile { Status = "Yes" },
                 new FamilyViolenceFile { Status = "No" },
                 new FamilyViolenceFile { Status = "N/A" }
            );
            context.SaveChanges();

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
            context.SaveChanges();

            //Adult >24 <65; Youth >12 <19; Youth >18 <25; Child<13; Senior >64
            context.Ages.AddOrUpdate(
                 ag => ag.AgeRange,
                 new Age { AgeRange = "Adult >24 <65" },
                 new Age { AgeRange = "Youth >18 <25" },
                 new Age { AgeRange = "Youth >12 <19" },
                 new Age { AgeRange = "Child<13" },
                 new Age { AgeRange = "Senior >64" }
            );
            context.SaveChanges();

            context.RepeatClients.AddOrUpdate(
                 rc => rc.Repeat,
                 new RepeatClient { Repeat = "Yes" },
                 new RepeatClient { Repeat = "" }
            );
            context.SaveChanges();

            context.DuplicateFiles.AddOrUpdate(
                 df => df.IsDuplicate,
                 new DuplicateFile { IsDuplicate = "Yes" },
                 new DuplicateFile { IsDuplicate = "" }
            );
            context.SaveChanges();

            context.FileStatus.AddOrUpdate(
                 files => files.Status,
                 new FileStatus { Status = "Yes" },
                 new FileStatus { Status = "" }
            );
            context.SaveChanges();

            //SMART
            context.SexWorkExploitations.AddOrUpdate(
                  swe => swe.Value,
                  new SexWorkExploitation { Value = "Yes" },
                  new SexWorkExploitation { Value = "No" },
                  new SexWorkExploitation { Value = "N/A" }
            );
            context.SaveChanges();

            context.MultiplePerpetrators.AddOrUpdate(
                  mp => mp.Value,
                  new MultiplePerpetrator { Value = "Yes" },
                  new MultiplePerpetrator { Value = "No" },
                  new MultiplePerpetrator { Value = "N/A" }
            );
            context.SaveChanges();

            context.DrugFacilitatedAssaults.AddOrUpdate(
                  dfa => dfa.Value,
                  new DrugFacilitatedAssault { Value = "Yes" },
                  new DrugFacilitatedAssault { Value = "No" },
                  new DrugFacilitatedAssault { Value = "N/A" }
            );
            context.SaveChanges();

            //Surrey; Abbotsford; Agassiz; Boston Bar; Burnaby;
            //Chilliwack; Coquitlam; Delta; Harrison Hot Springs;
            //Hope; Langley; Maple Ridge; Mission; New Westminster;
            //Pitt Meadows; Port Coquitlam; Port Moody; Vancouver;
            //White Rock; Yale; Other � BC; Out-of-Province; International
            context.Cities.AddOrUpdate(
                  cit => cit.CityName,
                  new City { CityName = "Surrey" },
                  new City { CityName = "Abbotsford" },
                  new City { CityName = "Agassiz" },
                  new City { CityName = "Boston Bar" },
                  new City { CityName = "Burnaby" },
                  new City { CityName = "Chilliwack" },
                  new City { CityName = "Coquitlam" },
                  new City { CityName = "Delta" },
                  new City { CityName = "Harrison Hot Springs" },
                  new City { CityName = "Hope" },
                  new City { CityName = "Langley" },
                  new City { CityName = "Maple Ridge" },
                  new City { CityName = "Mission" },
                  new City { CityName = "New Westminster" },
                  new City { CityName = "Pitt Meadows" },
                  new City { CityName = "Port Coquitlam" },
                  new City { CityName = "Port Moody" },
                  new City { CityName = "Vancouver" },
                  new City { CityName = "White Rock" },
                  new City { CityName = "Yale" },
                  new City { CityName = "Other � BC" },
                  new City { CityName = "Out-of-Province" },
                  new City { CityName = "International" }
            );
            context.SaveChanges();

            //Abbotsford Regional Hospital; Surrey Memorial Hospital; 
            //Burnaby Hospital; Chilliwack General Hospital; Delta Hospital;
            //Eagle Ridge Hospital; Fraser Canyon Hospital; Langley Hospital;
            //Mission Hospital; Peace Arch Hospital; Ridge Meadows Hospital;
            //Royal Columbia Hospital
            context.Hospitals.AddOrUpdate(
                  hos => hos.HospitalName,
                  new Hospital { HospitalName = "Abbotsford Regional Hospital" },
                  new Hospital { HospitalName = "Surrey Memorial Hospital" },
                  new Hospital { HospitalName = "Burnaby Hospital" },
                  new Hospital { HospitalName = "Chilliwack General Hospital" },
                  new Hospital { HospitalName = "Delta Hospital" },
                  new Hospital { HospitalName = "Eagle Ridge Hospital" },
                  new Hospital { HospitalName = "Fraser Canyon Hospital" },
                  new Hospital { HospitalName = "Langley Hospital" },
                  new Hospital { HospitalName = "Mission Hospital" },
                  new Hospital { HospitalName = "Peace Arch Hospital" },
                  new Hospital { HospitalName = "Ridge Meadows Hospital" },
                  new Hospital { HospitalName = "Royal Columbia Hospital" }
            );
            context.SaveChanges();

            context.SocialWorkAttendances.AddOrUpdate(
                  swa => swa.Value,
                  new SocialWorkAttendance { Value = "Yes" },
                  new SocialWorkAttendance { Value = "No" },
                  new SocialWorkAttendance { Value = "N/A" }
            );
            context.SaveChanges();

            context.PoliceAttendances.AddOrUpdate(
                  copa => copa.Value,
                  new PoliceAttendance { Value = "Yes" },
                  new PoliceAttendance { Value = "No" },
                  new PoliceAttendance { Value = "N/A" }
            );
            context.SaveChanges();

            context.VictimServicesAttendances.AddOrUpdate(
                  vsa => vsa.Value,
                  new VictimServicesAttendance { Value = "Yes" },
                  new VictimServicesAttendance { Value = "No" },
                  new VictimServicesAttendance { Value = "N/A" }
            );
            context.SaveChanges();

            context.MedicalOnlies.AddOrUpdate(
                  mo => mo.Value,
                  new MedicalOnly { Value = "Yes" },
                  new MedicalOnly { Value = "No" },
                  new MedicalOnly { Value = "N/A" }
            );
            context.SaveChanges();

            context.EvidenceStoreds.AddOrUpdate(
                  es => es.Value,
                  new EvidenceStored { Value = "Yes" },
                  new EvidenceStored { Value = "No" },
                  new EvidenceStored { Value = "N/A" }
            );
            context.SaveChanges();

            context.HIVMeds.AddOrUpdate(
                  hiv => hiv.Value,
                  new HIVMeds { Value = "Yes" },
                  new HIVMeds { Value = "No" },
                  new HIVMeds { Value = "N/A" }
            );
            context.SaveChanges();

            context.ReferCBVS.AddOrUpdate(
                  cbvs => cbvs.Value,
                  new ReferCBVS { Value = "Yes" },
                  new ReferCBVS { Value = "No" },
                  new ReferCBVS { Value = "PVBS only" },
                  new ReferCBVS { Value = "N/A" }
            );
            context.SaveChanges();

            context.PoliceReporteds.AddOrUpdate(
                  copr => copr.Value,
                  new PoliceReported { Value = "Yes" },
                  new PoliceReported { Value = "No" },
                  new PoliceReported { Value = "N/A" }
            );
            context.SaveChanges();

            context.ThirdPartyReports.AddOrUpdate(
                  tpr => tpr.Value,
                  new ThirdPartyReport { Value = "Yes" },
                  new ThirdPartyReport { Value = "No" },
                  new ThirdPartyReport { Value = "N/A" }
            );
            context.SaveChanges();

            context.BadDateReports.AddOrUpdate(
                  bd => bd.Value,
                  new BadDateReport { Value = "Yes" },
                  new BadDateReport { Value = "No" },
                  new BadDateReport { Value = "N/A" }
            );
            context.SaveChanges();

        }
    }
}
