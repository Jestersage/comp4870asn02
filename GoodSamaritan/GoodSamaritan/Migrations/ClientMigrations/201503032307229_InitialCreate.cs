namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNum = c.String(),
                        CourtFileNum = c.Int(nullable: false),
                        SWCFileNum = c.Int(nullable: false),
                        RiskAccessmentAssignedTo = c.String(),
                        AbuserSurname = c.String(),
                        AbuserFirstName = c.String(),
                        NumChildrenAgeZeroSix = c.Int(nullable: false),
                        NumChildrenAgeSevenTweleve = c.Int(nullable: false),
                        NumChildrenAgeTeens = c.Int(nullable: false),
                        DateLastTransfer = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReopened = c.DateTime(nullable: false),
                        Crisis_CrisisId = c.Int(),
                        FiscalYear_FiscalYearId = c.Int(),
                        Program_ProgramId = c.Int(),
                        RiskLevel_RiskLevelId = c.Int(),
                        RiskStatus_RiskStatusId = c.Int(),
                        Serivce_ServiceId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Crises", t => t.Crisis_CrisisId)
                .ForeignKey("dbo.FiscalYears", t => t.FiscalYear_FiscalYearId)
                .ForeignKey("dbo.Programs", t => t.Program_ProgramId)
                .ForeignKey("dbo.RiskLevels", t => t.RiskLevel_RiskLevelId)
                .ForeignKey("dbo.RiskStatus", t => t.RiskStatus_RiskStatusId)
                .ForeignKey("dbo.Services", t => t.Serivce_ServiceId)
                .Index(t => t.Crisis_CrisisId)
                .Index(t => t.FiscalYear_FiscalYearId)
                .Index(t => t.Program_ProgramId)
                .Index(t => t.RiskLevel_RiskLevelId)
                .Index(t => t.RiskStatus_RiskStatusId)
                .Index(t => t.Serivce_ServiceId);
            
            CreateTable(
                "dbo.Crises",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        CrisisName = c.String(),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.FiscalYears",
                c => new
                    {
                        FiscalYearId = c.Int(nullable: false, identity: true),
                        FiscalYearName = c.String(),
                    })
                .PrimaryKey(t => t.FiscalYearId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        ProgramName = c.String(),
                    })
                .PrimaryKey(t => t.ProgramId);
            
            CreateTable(
                "dbo.RiskLevels",
                c => new
                    {
                        RiskLevelId = c.Int(nullable: false, identity: true),
                        RiskLevelValue = c.String(),
                    })
                .PrimaryKey(t => t.RiskLevelId);
            
            CreateTable(
                "dbo.RiskStatus",
                c => new
                    {
                        RiskStatusId = c.Int(nullable: false, identity: true),
                        RiskStatusValue = c.String(),
                    })
                .PrimaryKey(t => t.RiskStatusId);
            
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceName = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserId = c.Int(nullable: false, identity: true),
                        Email = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "Serivce_ServiceId", "dbo.Services");
            DropForeignKey("dbo.Clients", "RiskStatus_RiskStatusId", "dbo.RiskStatus");
            DropForeignKey("dbo.Clients", "RiskLevel_RiskLevelId", "dbo.RiskLevels");
            DropForeignKey("dbo.Clients", "Program_ProgramId", "dbo.Programs");
            DropForeignKey("dbo.Clients", "FiscalYear_FiscalYearId", "dbo.FiscalYears");
            DropForeignKey("dbo.Clients", "Crisis_CrisisId", "dbo.Crises");
            DropIndex("dbo.Clients", new[] { "Serivce_ServiceId" });
            DropIndex("dbo.Clients", new[] { "RiskStatus_RiskStatusId" });
            DropIndex("dbo.Clients", new[] { "RiskLevel_RiskLevelId" });
            DropIndex("dbo.Clients", new[] { "Program_ProgramId" });
            DropIndex("dbo.Clients", new[] { "FiscalYear_FiscalYearId" });
            DropIndex("dbo.Clients", new[] { "Crisis_CrisisId" });
            DropTable("dbo.Users");
            DropTable("dbo.Services");
            DropTable("dbo.RiskStatus");
            DropTable("dbo.RiskLevels");
            DropTable("dbo.Programs");
            DropTable("dbo.FiscalYears");
            DropTable("dbo.Crises");
            DropTable("dbo.Clients");
        }
    }
}
