namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.BadDateReports",
                c => new
                    {
                        BadDateReportId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.BadDateReportId);
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityId = c.Int(nullable: false, identity: true),
                        CityName = c.String(),
                    })
                .PrimaryKey(t => t.CityId);
            
            CreateTable(
                "dbo.DrugFacilitatedAssaults",
                c => new
                    {
                        DrugFacilitatedAssaultId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.DrugFacilitatedAssaultId);
            
            CreateTable(
                "dbo.EvidenceStoreds",
                c => new
                    {
                        EvidenceStoredId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.EvidenceStoredId);
            
            CreateTable(
                "dbo.HIVMeds",
                c => new
                    {
                        HIVMedsId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.HIVMedsId);
            
            CreateTable(
                "dbo.Hospitals",
                c => new
                    {
                        HospitalId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(),
                    })
                .PrimaryKey(t => t.HospitalId);
            
            CreateTable(
                "dbo.MedicalOnlies",
                c => new
                    {
                        MedicalOnlyId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.MedicalOnlyId);
            
            CreateTable(
                "dbo.MultiplePerpetrators",
                c => new
                    {
                        MultiplePerpetratorId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.MultiplePerpetratorId);
            
            CreateTable(
                "dbo.PoliceAttendances",
                c => new
                    {
                        PoliceAttendanceId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.PoliceAttendanceId);
            
            CreateTable(
                "dbo.PoliceReporteds",
                c => new
                    {
                        PoliceReportedId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.PoliceReportedId);
            
            CreateTable(
                "dbo.ReferCBVS",
                c => new
                    {
                        ReferCBVSId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.ReferCBVSId);
            
            CreateTable(
                "dbo.SexWorkExploitations",
                c => new
                    {
                        SexWorkExploitationId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.SexWorkExploitationId);
            
            CreateTable(
                "dbo.Smarts",
                c => new
                    {
                        SmartId = c.Int(nullable: false, identity: true),
                        ClientId = c.Int(nullable: false),
                        AccompanimentMinutes = c.Int(nullable: false),
                        NumTransportProvided = c.Int(nullable: false),
                        ReferToNurse = c.Boolean(nullable: false),
                        BadDate_BadDateReportId = c.Int(),
                        CityAssault_CityId = c.Int(),
                        CityResidence_CityId = c.Int(),
                        DrugAssault_DrugFacilitatedAssaultId = c.Int(),
                        Evidence_EvidenceStoredId = c.Int(),
                        Exploitation_SexWorkExploitationId = c.Int(),
                        HIVMeds_HIVMedsId = c.Int(),
                        HospitalAttended_HospitalId = c.Int(),
                        MedicalOnly_MedicalOnlyId = c.Int(),
                        MultiPerp_MultiplePerpetratorId = c.Int(),
                        PoliceAttendence_PoliceAttendanceId = c.Int(),
                        PoliceReported_PoliceReportedId = c.Int(),
                        ReferCBVS_ReferCBVSId = c.Int(),
                        ReferringHospital_HospitalId = c.Int(),
                        SocialWorkAttendence_SocialWorkAttendanceId = c.Int(),
                        ThirdParty_ThirdPartyReportId = c.Int(),
                        VictimServices_VictimServicesAttendanceId = c.Int(),
                    })
                .PrimaryKey(t => t.SmartId)
                .ForeignKey("dbo.BadDateReports", t => t.BadDate_BadDateReportId)
                .ForeignKey("dbo.Cities", t => t.CityAssault_CityId)
                .ForeignKey("dbo.Cities", t => t.CityResidence_CityId)
                .ForeignKey("dbo.DrugFacilitatedAssaults", t => t.DrugAssault_DrugFacilitatedAssaultId)
                .ForeignKey("dbo.EvidenceStoreds", t => t.Evidence_EvidenceStoredId)
                .ForeignKey("dbo.SexWorkExploitations", t => t.Exploitation_SexWorkExploitationId)
                .ForeignKey("dbo.HIVMeds", t => t.HIVMeds_HIVMedsId)
                .ForeignKey("dbo.Hospitals", t => t.HospitalAttended_HospitalId)
                .ForeignKey("dbo.MedicalOnlies", t => t.MedicalOnly_MedicalOnlyId)
                .ForeignKey("dbo.MultiplePerpetrators", t => t.MultiPerp_MultiplePerpetratorId)
                .ForeignKey("dbo.PoliceAttendances", t => t.PoliceAttendence_PoliceAttendanceId)
                .ForeignKey("dbo.PoliceReporteds", t => t.PoliceReported_PoliceReportedId)
                .ForeignKey("dbo.ReferCBVS", t => t.ReferCBVS_ReferCBVSId)
                .ForeignKey("dbo.Hospitals", t => t.ReferringHospital_HospitalId)
                .ForeignKey("dbo.SocialWorkAttendances", t => t.SocialWorkAttendence_SocialWorkAttendanceId)
                .ForeignKey("dbo.ThirdPartyReports", t => t.ThirdParty_ThirdPartyReportId)
                .ForeignKey("dbo.VictimServicesAttendances", t => t.VictimServices_VictimServicesAttendanceId)
                .Index(t => t.BadDate_BadDateReportId)
                .Index(t => t.CityAssault_CityId)
                .Index(t => t.CityResidence_CityId)
                .Index(t => t.DrugAssault_DrugFacilitatedAssaultId)
                .Index(t => t.Evidence_EvidenceStoredId)
                .Index(t => t.Exploitation_SexWorkExploitationId)
                .Index(t => t.HIVMeds_HIVMedsId)
                .Index(t => t.HospitalAttended_HospitalId)
                .Index(t => t.MedicalOnly_MedicalOnlyId)
                .Index(t => t.MultiPerp_MultiplePerpetratorId)
                .Index(t => t.PoliceAttendence_PoliceAttendanceId)
                .Index(t => t.PoliceReported_PoliceReportedId)
                .Index(t => t.ReferCBVS_ReferCBVSId)
                .Index(t => t.ReferringHospital_HospitalId)
                .Index(t => t.SocialWorkAttendence_SocialWorkAttendanceId)
                .Index(t => t.ThirdParty_ThirdPartyReportId)
                .Index(t => t.VictimServices_VictimServicesAttendanceId);
            
            CreateTable(
                "dbo.SocialWorkAttendances",
                c => new
                    {
                        SocialWorkAttendanceId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.SocialWorkAttendanceId);
            
            CreateTable(
                "dbo.ThirdPartyReports",
                c => new
                    {
                        ThirdPartyReportId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.ThirdPartyReportId);
            
            CreateTable(
                "dbo.VictimServicesAttendances",
                c => new
                    {
                        VictimServicesAttendanceId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.VictimServicesAttendanceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Smarts", "VictimServices_VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropForeignKey("dbo.Smarts", "ThirdParty_ThirdPartyReportId", "dbo.ThirdPartyReports");
            DropForeignKey("dbo.Smarts", "SocialWorkAttendence_SocialWorkAttendanceId", "dbo.SocialWorkAttendances");
            DropForeignKey("dbo.Smarts", "ReferringHospital_HospitalId", "dbo.Hospitals");
            DropForeignKey("dbo.Smarts", "ReferCBVS_ReferCBVSId", "dbo.ReferCBVS");
            DropForeignKey("dbo.Smarts", "PoliceReported_PoliceReportedId", "dbo.PoliceReporteds");
            DropForeignKey("dbo.Smarts", "PoliceAttendence_PoliceAttendanceId", "dbo.PoliceAttendances");
            DropForeignKey("dbo.Smarts", "MultiPerp_MultiplePerpetratorId", "dbo.MultiplePerpetrators");
            DropForeignKey("dbo.Smarts", "MedicalOnly_MedicalOnlyId", "dbo.MedicalOnlies");
            DropForeignKey("dbo.Smarts", "HospitalAttended_HospitalId", "dbo.Hospitals");
            DropForeignKey("dbo.Smarts", "HIVMeds_HIVMedsId", "dbo.HIVMeds");
            DropForeignKey("dbo.Smarts", "Exploitation_SexWorkExploitationId", "dbo.SexWorkExploitations");
            DropForeignKey("dbo.Smarts", "Evidence_EvidenceStoredId", "dbo.EvidenceStoreds");
            DropForeignKey("dbo.Smarts", "DrugAssault_DrugFacilitatedAssaultId", "dbo.DrugFacilitatedAssaults");
            DropForeignKey("dbo.Smarts", "CityResidence_CityId", "dbo.Cities");
            DropForeignKey("dbo.Smarts", "CityAssault_CityId", "dbo.Cities");
            DropForeignKey("dbo.Smarts", "BadDate_BadDateReportId", "dbo.BadDateReports");
            DropIndex("dbo.Smarts", new[] { "VictimServices_VictimServicesAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "ThirdParty_ThirdPartyReportId" });
            DropIndex("dbo.Smarts", new[] { "SocialWorkAttendence_SocialWorkAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "ReferringHospital_HospitalId" });
            DropIndex("dbo.Smarts", new[] { "ReferCBVS_ReferCBVSId" });
            DropIndex("dbo.Smarts", new[] { "PoliceReported_PoliceReportedId" });
            DropIndex("dbo.Smarts", new[] { "PoliceAttendence_PoliceAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "MultiPerp_MultiplePerpetratorId" });
            DropIndex("dbo.Smarts", new[] { "MedicalOnly_MedicalOnlyId" });
            DropIndex("dbo.Smarts", new[] { "HospitalAttended_HospitalId" });
            DropIndex("dbo.Smarts", new[] { "HIVMeds_HIVMedsId" });
            DropIndex("dbo.Smarts", new[] { "Exploitation_SexWorkExploitationId" });
            DropIndex("dbo.Smarts", new[] { "Evidence_EvidenceStoredId" });
            DropIndex("dbo.Smarts", new[] { "DrugAssault_DrugFacilitatedAssaultId" });
            DropIndex("dbo.Smarts", new[] { "CityResidence_CityId" });
            DropIndex("dbo.Smarts", new[] { "CityAssault_CityId" });
            DropIndex("dbo.Smarts", new[] { "BadDate_BadDateReportId" });
            DropTable("dbo.VictimServicesAttendances");
            DropTable("dbo.ThirdPartyReports");
            DropTable("dbo.SocialWorkAttendances");
            DropTable("dbo.Smarts");
            DropTable("dbo.SexWorkExploitations");
            DropTable("dbo.ReferCBVS");
            DropTable("dbo.PoliceReporteds");
            DropTable("dbo.PoliceAttendances");
            DropTable("dbo.MultiplePerpetrators");
            DropTable("dbo.MedicalOnlies");
            DropTable("dbo.Hospitals");
            DropTable("dbo.HIVMeds");
            DropTable("dbo.EvidenceStoreds");
            DropTable("dbo.DrugFacilitatedAssaults");
            DropTable("dbo.Cities");
            DropTable("dbo.BadDateReports");
        }
    }
}
