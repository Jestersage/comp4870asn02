using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public virtual Smart.Smart Smarts { get; set; }

        //public string FiscalYearName { get; set; }
        public int FiscalYearId { get; set; }
        public virtual FiscalYear FiscalYear { get; set; }

        public int Month { get; set; }
        public int Day { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }

        //Format: 99-99999, or null
        public string PoliceFileNum { get; set; }
        
        //nullable
        public int CourtFileNum { get; set; }
        public int SWCFileNum { get; set; }

        //public string RiskLevelValue { get; set; }
        public int RiskLevelId { get; set; }
        public virtual RiskLevel RiskLevel { get; set; }

        //public string CrisisName { get; set; }
        public int CrisisId { get; set; }
        public virtual Crisis Crisis { get; set; }

        //public string ServiceName { get; set; }
        public int ServiceId { get; set; }
        public virtual Service Serivce { get; set; }

        //Program If Program == SMART, refer to smart.
        //public string ProgramName { get; set; }
        public int ProgramId { get; set; }
        public virtual Program Program { get; set; }

        public string RiskAccessmentAssignedTo{ get; set; }

        //public string RiskStatusValue { get; set; }
        public int RiskStatusId { get; set; }
        public virtual RiskStatus RiskStatus { get; set; }

        //public string AssignedWorkerName { get; set; }
        public int AssignedWorkerId { get; set; }
        public virtual AssignedWorker AssignedWorker { get; set; }

        public string Source { get; set; }
        public virtual ReferralSource ReferralSource { get; set; }

        //public string ReferralContactName { get; set; }
        public int ReferralSourceId { get; set; }
        public virtual ReferralContact ReferralContact { get; set; }

        //public string IncidentType { get; set; }
        public int IncidentId { get; set; }
        public virtual Incident Incident { get; set; }


        public string AbuserSurname { get; set; }
        public string AbuserFirstName { get; set; }

        //public string Type { get; set; }
        public int AbuserRelationshipId { get; set; }
        public virtual AbuserRelationship Relationship { get; set; }

        //public string VictimType { get; set; }
        public int VictimId { get; set; }
        public virtual Victim VictimOfIncident { get; set; }

        //public string Status { get; set; }
        public int FamilyViolenceFileId { get; set; }
        public virtual FamilyViolenceFile File { get; set; }
        //char Gender //(M, F, Trans) Lookup too??
        public char Gender { get; set; }

        //public string Ethnictiy { get; set; }
        public int EthnicityId { get; set; }
        public virtual Ethnicity Race { get; set; }

        //public string AgeRange { get; set; }
        public int AgeId { get; set; }
        public virtual Age age { get; set; }

        //public string Repeat { get; set; }
        //Yes or null. Need to check if same fiscal year
        public int RepeatClientId { get; set; }
        public virtual RepeatClient RepeatClient { get; set; }
        
        //Yes or null. Need to check if same fiscal year
        //public string IsDuplicate { get; set; }
        public int DuplicateFileId { get; set; }
        public virtual DuplicateFile DuplicateFile { get; set; }

        public int NumChildrenAgeZeroSix { get; set; }
        public int NumChildrenAgeSevenTweleve { get; set; }
        public int NumChildrenAgeTeens { get; set; }
       
        //Reopen; Closed; Open
        //public string FileStatusString { get; set; }
        public int FileStatusId { get; set; }
        public virtual FileStatus FileStatuse { get; set; }

        public DateTime DateLastTransfer { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReopened { get; set; }
    }
}