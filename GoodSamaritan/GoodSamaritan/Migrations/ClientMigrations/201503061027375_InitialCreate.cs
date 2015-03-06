namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            RenameColumn(table: "dbo.Smarts", name: "CityResidence_CityId", newName: "CityResidence_CityResId");
            RenameColumn(table: "dbo.Smarts", name: "HospitalAttended_HospitalId", newName: "HospitalAttended_HospitalAttId");
            RenameIndex(table: "dbo.Smarts", name: "IX_CityResidence_CityId", newName: "IX_CityResidence_CityResId");
            RenameIndex(table: "dbo.Smarts", name: "IX_HospitalAttended_HospitalId", newName: "IX_HospitalAttended_HospitalAttId");
            CreateTable(
                "dbo.CityRes",
                c => new
                    {
                        CityResId = c.Int(nullable: false, identity: true),
                        CityResName = c.String(),
                    })
                .PrimaryKey(t => t.CityResId);
            
            CreateTable(
                "dbo.HospitalAtts",
                c => new
                    {
                        HospitalAttId = c.Int(nullable: false, identity: true),
                        HospitalAttName = c.String(),
                    })
                .PrimaryKey(t => t.HospitalAttId);
            
            AddColumn("dbo.Clients", "Smarts_SmartId", c => c.Int());
            CreateIndex("dbo.Clients", "Smarts_SmartId");
            AddForeignKey("dbo.Clients", "Smarts_SmartId", "dbo.Smarts", "SmartId");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Smarts_SmartId", "dbo.Smarts");
            DropIndex("dbo.Clients", new[] { "Smarts_SmartId" });
            DropColumn("dbo.Clients", "Smarts_SmartId");
            DropTable("dbo.HospitalAtts");
            DropTable("dbo.CityRes");
            RenameIndex(table: "dbo.Smarts", name: "IX_HospitalAttended_HospitalAttId", newName: "IX_HospitalAttended_HospitalId");
            RenameIndex(table: "dbo.Smarts", name: "IX_CityResidence_CityResId", newName: "IX_CityResidence_CityId");
            RenameColumn(table: "dbo.Smarts", name: "HospitalAttended_HospitalAttId", newName: "HospitalAttended_HospitalId");
            RenameColumn(table: "dbo.Smarts", name: "CityResidence_CityResId", newName: "CityResidence_CityId");
        }
    }
}
