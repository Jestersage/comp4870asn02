namespace GoodSamaritan.Migrations.ClientMigrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AbuserRelationships",
                c => new
                    {
                        AbuserRelationshipId = c.Int(nullable: false, identity: true),
                        Type = c.String(),
                    })
                .PrimaryKey(t => t.AbuserRelationshipId);
            
            CreateTable(
                "dbo.Clients",
                c => new
                    {
                        ClientId = c.Int(nullable: false, identity: true),
                        FiscalYearId = c.Int(nullable: false),
                        Month = c.Int(nullable: false),
                        Day = c.Int(nullable: false),
                        Surname = c.String(),
                        FirstName = c.String(),
                        PoliceFileNum = c.String(),
                        CourtFileNum = c.Int(nullable: false),
                        SWCFileNum = c.Int(nullable: false),
                        RiskLevelId = c.Int(nullable: false),
                        CrisisId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        ProgramId = c.Int(nullable: false),
                        RiskAccessmentAssignedTo = c.String(),
                        RiskStatusId = c.Int(nullable: false),
                        AssignedWorkerId = c.Int(nullable: false),
                        Source = c.String(),
                        ReferralSourceId = c.Int(nullable: false),
                        IncidentId = c.Int(nullable: false),
                        AbuserSurname = c.String(),
                        AbuserFirstName = c.String(),
                        AbuserRelationshipId = c.Int(nullable: false),
                        VictimId = c.Int(nullable: false),
                        FamilyViolenceFileId = c.Int(nullable: false),
                        EthnicityId = c.Int(nullable: false),
                        AgeId = c.Int(nullable: false),
                        RepeatClientId = c.Int(nullable: false),
                        DuplicateFileId = c.Int(nullable: false),
                        NumChildrenAgeZeroSix = c.Int(nullable: false),
                        NumChildrenAgeSevenTweleve = c.Int(nullable: false),
                        NumChildrenAgeTeens = c.Int(nullable: false),
                        FileStatusId = c.Int(nullable: false),
                        DateLastTransfer = c.DateTime(nullable: false),
                        DateClosed = c.DateTime(nullable: false),
                        DateReopened = c.DateTime(nullable: false),
                        ReferralContact_ReferralContactId = c.Int(),
                        Smarts_SmartId = c.Int(),
                    })
                .PrimaryKey(t => t.ClientId)
                .ForeignKey("dbo.Ages", t => t.AgeId, cascadeDelete: true)
                .ForeignKey("dbo.AssignedWorkers", t => t.AssignedWorkerId, cascadeDelete: true)
                .ForeignKey("dbo.Crises", t => t.CrisisId, cascadeDelete: true)
                .ForeignKey("dbo.DuplicateFiles", t => t.DuplicateFileId, cascadeDelete: true)
                .ForeignKey("dbo.FamilyViolenceFiles", t => t.FamilyViolenceFileId, cascadeDelete: true)
                .ForeignKey("dbo.FileStatus", t => t.FileStatusId, cascadeDelete: true)
                .ForeignKey("dbo.FiscalYears", t => t.FiscalYearId, cascadeDelete: true)
                .ForeignKey("dbo.Incidents", t => t.IncidentId, cascadeDelete: true)
                .ForeignKey("dbo.Programs", t => t.ProgramId, cascadeDelete: true)
                .ForeignKey("dbo.Ethnicities", t => t.EthnicityId, cascadeDelete: true)
                .ForeignKey("dbo.ReferralContacts", t => t.ReferralContact_ReferralContactId)
                .ForeignKey("dbo.ReferralSources", t => t.ReferralSourceId, cascadeDelete: true)
                .ForeignKey("dbo.AbuserRelationships", t => t.AbuserRelationshipId, cascadeDelete: true)
                .ForeignKey("dbo.RepeatClients", t => t.RepeatClientId, cascadeDelete: true)
                .ForeignKey("dbo.RiskLevels", t => t.RiskLevelId, cascadeDelete: true)
                .ForeignKey("dbo.RiskStatus", t => t.RiskStatusId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.Smarts", t => t.Smarts_SmartId)
                .ForeignKey("dbo.Victims", t => t.VictimId, cascadeDelete: true)
                .Index(t => t.FiscalYearId)
                .Index(t => t.RiskLevelId)
                .Index(t => t.CrisisId)
                .Index(t => t.ServiceId)
                .Index(t => t.ProgramId)
                .Index(t => t.RiskStatusId)
                .Index(t => t.AssignedWorkerId)
                .Index(t => t.ReferralSourceId)
                .Index(t => t.IncidentId)
                .Index(t => t.AbuserRelationshipId)
                .Index(t => t.VictimId)
                .Index(t => t.FamilyViolenceFileId)
                .Index(t => t.EthnicityId)
                .Index(t => t.AgeId)
                .Index(t => t.RepeatClientId)
                .Index(t => t.DuplicateFileId)
                .Index(t => t.FileStatusId)
                .Index(t => t.ReferralContact_ReferralContactId)
                .Index(t => t.Smarts_SmartId);
            
            CreateTable(
                "dbo.Ages",
                c => new
                    {
                        AgeId = c.Int(nullable: false, identity: true),
                        AgeRange = c.String(),
                    })
                .PrimaryKey(t => t.AgeId);
            
            CreateTable(
                "dbo.AssignedWorkers",
                c => new
                    {
                        AssignedWorkerId = c.Int(nullable: false, identity: true),
                        AssignedWorkerName = c.String(),
                    })
                .PrimaryKey(t => t.AssignedWorkerId);
            
            CreateTable(
                "dbo.Crises",
                c => new
                    {
                        CrisisId = c.Int(nullable: false, identity: true),
                        CrisisName = c.String(),
                    })
                .PrimaryKey(t => t.CrisisId);
            
            CreateTable(
                "dbo.DuplicateFiles",
                c => new
                    {
                        DuplicateFileId = c.Int(nullable: false, identity: true),
                        IsDuplicate = c.String(),
                    })
                .PrimaryKey(t => t.DuplicateFileId);
            
            CreateTable(
                "dbo.FamilyViolenceFiles",
                c => new
                    {
                        FamilyViolenceFileId = c.Int(nullable: false, identity: true),
                        Status = c.String(),
                    })
                .PrimaryKey(t => t.FamilyViolenceFileId);
            
            CreateTable(
                "dbo.FileStatus",
                c => new
                    {
                        FileStatusId = c.Int(nullable: false, identity: true),
                        FileStatusString = c.String(),
                    })
                .PrimaryKey(t => t.FileStatusId);
            
            CreateTable(
                "dbo.FiscalYears",
                c => new
                    {
                        FiscalYearId = c.Int(nullable: false, identity: true),
                        FiscalYearName = c.String(),
                    })
                .PrimaryKey(t => t.FiscalYearId);
            
            CreateTable(
                "dbo.Incidents",
                c => new
                    {
                        IncidentId = c.Int(nullable: false, identity: true),
                        IncidentType = c.String(),
                    })
                .PrimaryKey(t => t.IncidentId);
            
            CreateTable(
                "dbo.Programs",
                c => new
                    {
                        ProgramId = c.Int(nullable: false, identity: true),
                        ProgramName = c.String(),
                    })
                .PrimaryKey(t => t.ProgramId);
            
            CreateTable(
                "dbo.Ethnicities",
                c => new
                    {
                        EthnicityId = c.Int(nullable: false, identity: true),
                        Ethnictiy = c.String(),
                    })
                .PrimaryKey(t => t.EthnicityId);
            
            CreateTable(
                "dbo.ReferralContacts",
                c => new
                    {
                        ReferralContactId = c.Int(nullable: false, identity: true),
                        ReferralContactName = c.String(),
                    })
                .PrimaryKey(t => t.ReferralContactId);
            
            CreateTable(
                "dbo.ReferralSources",
                c => new
                    {
                        ReferralSourceId = c.Int(nullable: false, identity: true),
                        Source = c.String(),
                    })
                .PrimaryKey(t => t.ReferralSourceId);
            
            CreateTable(
                "dbo.RepeatClients",
                c => new
                    {
                        RepeatClientId = c.Int(nullable: false, identity: true),
                        Repeat = c.String(),
                    })
                .PrimaryKey(t => t.RepeatClientId);
            
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
                        CityResidence_CityResId = c.Int(),
                        DrugAssault_DrugFacilitatedAssaultId = c.Int(),
                        Evidence_EvidenceStoredId = c.Int(),
                        Exploitation_SexWorkExploitationId = c.Int(),
                        HIVMeds_HIVMedsId = c.Int(),
                        HospitalAttended_HospitalAttId = c.Int(),
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
                .ForeignKey("dbo.CityRes", t => t.CityResidence_CityResId)
                .ForeignKey("dbo.DrugFacilitatedAssaults", t => t.DrugAssault_DrugFacilitatedAssaultId)
                .ForeignKey("dbo.EvidenceStoreds", t => t.Evidence_EvidenceStoredId)
                .ForeignKey("dbo.SexWorkExploitations", t => t.Exploitation_SexWorkExploitationId)
                .ForeignKey("dbo.HIVMeds", t => t.HIVMeds_HIVMedsId)
                .ForeignKey("dbo.HospitalAtts", t => t.HospitalAttended_HospitalAttId)
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
                .Index(t => t.CityResidence_CityResId)
                .Index(t => t.DrugAssault_DrugFacilitatedAssaultId)
                .Index(t => t.Evidence_EvidenceStoredId)
                .Index(t => t.Exploitation_SexWorkExploitationId)
                .Index(t => t.HIVMeds_HIVMedsId)
                .Index(t => t.HospitalAttended_HospitalAttId)
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
                "dbo.CityRes",
                c => new
                    {
                        CityResId = c.Int(nullable: false, identity: true),
                        CityResName = c.String(),
                    })
                .PrimaryKey(t => t.CityResId);
            
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
                "dbo.SexWorkExploitations",
                c => new
                    {
                        SexWorkExploitationId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.SexWorkExploitationId);
            
            CreateTable(
                "dbo.HIVMeds",
                c => new
                    {
                        HIVMedsId = c.Int(nullable: false, identity: true),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.HIVMedsId);
            
            CreateTable(
                "dbo.HospitalAtts",
                c => new
                    {
                        HospitalAttId = c.Int(nullable: false, identity: true),
                        HospitalAttName = c.String(),
                    })
                .PrimaryKey(t => t.HospitalAttId);
            
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
                "dbo.Hospitals",
                c => new
                    {
                        HospitalId = c.Int(nullable: false, identity: true),
                        HospitalName = c.String(),
                    })
                .PrimaryKey(t => t.HospitalId);
            
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
            
            CreateTable(
                "dbo.Victims",
                c => new
                    {
                        VictimId = c.Int(nullable: false, identity: true),
                        VictimType = c.String(),
                    })
                .PrimaryKey(t => t.VictimId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Clients", "VictimId", "dbo.Victims");
            DropForeignKey("dbo.Smarts", "VictimServices_VictimServicesAttendanceId", "dbo.VictimServicesAttendances");
            DropForeignKey("dbo.Smarts", "ThirdParty_ThirdPartyReportId", "dbo.ThirdPartyReports");
            DropForeignKey("dbo.Smarts", "SocialWorkAttendence_SocialWorkAttendanceId", "dbo.SocialWorkAttendances");
            DropForeignKey("dbo.Smarts", "ReferringHospital_HospitalId", "dbo.Hospitals");
            DropForeignKey("dbo.Smarts", "ReferCBVS_ReferCBVSId", "dbo.ReferCBVS");
            DropForeignKey("dbo.Smarts", "PoliceReported_PoliceReportedId", "dbo.PoliceReporteds");
            DropForeignKey("dbo.Smarts", "PoliceAttendence_PoliceAttendanceId", "dbo.PoliceAttendances");
            DropForeignKey("dbo.Smarts", "MultiPerp_MultiplePerpetratorId", "dbo.MultiplePerpetrators");
            DropForeignKey("dbo.Smarts", "MedicalOnly_MedicalOnlyId", "dbo.MedicalOnlies");
            DropForeignKey("dbo.Smarts", "HospitalAttended_HospitalAttId", "dbo.HospitalAtts");
            DropForeignKey("dbo.Smarts", "HIVMeds_HIVMedsId", "dbo.HIVMeds");
            DropForeignKey("dbo.Smarts", "Exploitation_SexWorkExploitationId", "dbo.SexWorkExploitations");
            DropForeignKey("dbo.Smarts", "Evidence_EvidenceStoredId", "dbo.EvidenceStoreds");
            DropForeignKey("dbo.Smarts", "DrugAssault_DrugFacilitatedAssaultId", "dbo.DrugFacilitatedAssaults");
            DropForeignKey("dbo.Clients", "Smarts_SmartId", "dbo.Smarts");
            DropForeignKey("dbo.Smarts", "CityResidence_CityResId", "dbo.CityRes");
            DropForeignKey("dbo.Smarts", "CityAssault_CityId", "dbo.Cities");
            DropForeignKey("dbo.Smarts", "BadDate_BadDateReportId", "dbo.BadDateReports");
            DropForeignKey("dbo.Clients", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.Clients", "RiskStatusId", "dbo.RiskStatus");
            DropForeignKey("dbo.Clients", "RiskLevelId", "dbo.RiskLevels");
            DropForeignKey("dbo.Clients", "RepeatClientId", "dbo.RepeatClients");
            DropForeignKey("dbo.Clients", "AbuserRelationshipId", "dbo.AbuserRelationships");
            DropForeignKey("dbo.Clients", "ReferralSourceId", "dbo.ReferralSources");
            DropForeignKey("dbo.Clients", "ReferralContact_ReferralContactId", "dbo.ReferralContacts");
            DropForeignKey("dbo.Clients", "EthnicityId", "dbo.Ethnicities");
            DropForeignKey("dbo.Clients", "ProgramId", "dbo.Programs");
            DropForeignKey("dbo.Clients", "IncidentId", "dbo.Incidents");
            DropForeignKey("dbo.Clients", "FiscalYearId", "dbo.FiscalYears");
            DropForeignKey("dbo.Clients", "FileStatusId", "dbo.FileStatus");
            DropForeignKey("dbo.Clients", "FamilyViolenceFileId", "dbo.FamilyViolenceFiles");
            DropForeignKey("dbo.Clients", "DuplicateFileId", "dbo.DuplicateFiles");
            DropForeignKey("dbo.Clients", "CrisisId", "dbo.Crises");
            DropForeignKey("dbo.Clients", "AssignedWorkerId", "dbo.AssignedWorkers");
            DropForeignKey("dbo.Clients", "AgeId", "dbo.Ages");
            DropIndex("dbo.Smarts", new[] { "VictimServices_VictimServicesAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "ThirdParty_ThirdPartyReportId" });
            DropIndex("dbo.Smarts", new[] { "SocialWorkAttendence_SocialWorkAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "ReferringHospital_HospitalId" });
            DropIndex("dbo.Smarts", new[] { "ReferCBVS_ReferCBVSId" });
            DropIndex("dbo.Smarts", new[] { "PoliceReported_PoliceReportedId" });
            DropIndex("dbo.Smarts", new[] { "PoliceAttendence_PoliceAttendanceId" });
            DropIndex("dbo.Smarts", new[] { "MultiPerp_MultiplePerpetratorId" });
            DropIndex("dbo.Smarts", new[] { "MedicalOnly_MedicalOnlyId" });
            DropIndex("dbo.Smarts", new[] { "HospitalAttended_HospitalAttId" });
            DropIndex("dbo.Smarts", new[] { "HIVMeds_HIVMedsId" });
            DropIndex("dbo.Smarts", new[] { "Exploitation_SexWorkExploitationId" });
            DropIndex("dbo.Smarts", new[] { "Evidence_EvidenceStoredId" });
            DropIndex("dbo.Smarts", new[] { "DrugAssault_DrugFacilitatedAssaultId" });
            DropIndex("dbo.Smarts", new[] { "CityResidence_CityResId" });
            DropIndex("dbo.Smarts", new[] { "CityAssault_CityId" });
            DropIndex("dbo.Smarts", new[] { "BadDate_BadDateReportId" });
            DropIndex("dbo.Clients", new[] { "Smarts_SmartId" });
            DropIndex("dbo.Clients", new[] { "ReferralContact_ReferralContactId" });
            DropIndex("dbo.Clients", new[] { "FileStatusId" });
            DropIndex("dbo.Clients", new[] { "DuplicateFileId" });
            DropIndex("dbo.Clients", new[] { "RepeatClientId" });
            DropIndex("dbo.Clients", new[] { "AgeId" });
            DropIndex("dbo.Clients", new[] { "EthnicityId" });
            DropIndex("dbo.Clients", new[] { "FamilyViolenceFileId" });
            DropIndex("dbo.Clients", new[] { "VictimId" });
            DropIndex("dbo.Clients", new[] { "AbuserRelationshipId" });
            DropIndex("dbo.Clients", new[] { "IncidentId" });
            DropIndex("dbo.Clients", new[] { "ReferralSourceId" });
            DropIndex("dbo.Clients", new[] { "AssignedWorkerId" });
            DropIndex("dbo.Clients", new[] { "RiskStatusId" });
            DropIndex("dbo.Clients", new[] { "ProgramId" });
            DropIndex("dbo.Clients", new[] { "ServiceId" });
            DropIndex("dbo.Clients", new[] { "CrisisId" });
            DropIndex("dbo.Clients", new[] { "RiskLevelId" });
            DropIndex("dbo.Clients", new[] { "FiscalYearId" });
            DropTable("dbo.Victims");
            DropTable("dbo.VictimServicesAttendances");
            DropTable("dbo.ThirdPartyReports");
            DropTable("dbo.SocialWorkAttendances");
            DropTable("dbo.Hospitals");
            DropTable("dbo.ReferCBVS");
            DropTable("dbo.PoliceReporteds");
            DropTable("dbo.PoliceAttendances");
            DropTable("dbo.MultiplePerpetrators");
            DropTable("dbo.MedicalOnlies");
            DropTable("dbo.HospitalAtts");
            DropTable("dbo.HIVMeds");
            DropTable("dbo.SexWorkExploitations");
            DropTable("dbo.EvidenceStoreds");
            DropTable("dbo.DrugFacilitatedAssaults");
            DropTable("dbo.CityRes");
            DropTable("dbo.Cities");
            DropTable("dbo.BadDateReports");
            DropTable("dbo.Smarts");
            DropTable("dbo.Services");
            DropTable("dbo.RiskStatus");
            DropTable("dbo.RiskLevels");
            DropTable("dbo.RepeatClients");
            DropTable("dbo.ReferralSources");
            DropTable("dbo.ReferralContacts");
            DropTable("dbo.Ethnicities");
            DropTable("dbo.Programs");
            DropTable("dbo.Incidents");
            DropTable("dbo.FiscalYears");
            DropTable("dbo.FileStatus");
            DropTable("dbo.FamilyViolenceFiles");
            DropTable("dbo.DuplicateFiles");
            DropTable("dbo.Crises");
            DropTable("dbo.AssignedWorkers");
            DropTable("dbo.Ages");
            DropTable("dbo.Clients");
            DropTable("dbo.AbuserRelationships");
        }
    }
}
