namespace GoodSamaritan.Migrations.ClientMigrations
{
    using GoodSamaritan.Models.Client;
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


        }
    }
}
