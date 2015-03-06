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

            context.BadDateReports.AddOrUpdate(
                  bd => bd.Value,
                  new BadDateReport { Value = "Yes" },
                  new BadDateReport { Value = "No" },
                  new BadDateReport { Value = "N/A" }
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
                  rs => rs.RiskStatusValue,
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
        }
    }
}
