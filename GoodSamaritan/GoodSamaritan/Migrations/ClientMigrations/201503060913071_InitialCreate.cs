namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Clients", "Smarts_SmartId", c => c.Int());
            AddColumn("dbo.Smarts", "City_CityId", c => c.Int());
            AddColumn("dbo.Smarts", "Hospital_HospitalId", c => c.Int());
            CreateIndex("dbo.Clients", "Smarts_SmartId");
            CreateIndex("dbo.Smarts", "City_CityId");
            CreateIndex("dbo.Smarts", "Hospital_HospitalId");
            AddForeignKey("dbo.Smarts", "City_CityId", "dbo.Cities", "CityId");
            AddForeignKey("dbo.Clients", "Smarts_SmartId", "dbo.Smarts", "SmartId");
            AddForeignKey("dbo.Smarts", "Hospital_HospitalId", "dbo.Hospitals", "HospitalId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smarts", "Hospital_HospitalId", "dbo.Hospitals");
            DropForeignKey("dbo.Clients", "Smarts_SmartId", "dbo.Smarts");
            DropForeignKey("dbo.Smarts", "City_CityId", "dbo.Cities");
            DropIndex("dbo.Smarts", new[] { "Hospital_HospitalId" });
            DropIndex("dbo.Smarts", new[] { "City_CityId" });
            DropIndex("dbo.Clients", new[] { "Smarts_SmartId" });
            DropColumn("dbo.Smarts", "Hospital_HospitalId");
            DropColumn("dbo.Smarts", "City_CityId");
            DropColumn("dbo.Clients", "Smarts_SmartId");
        }
    }
}
