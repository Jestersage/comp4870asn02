using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }
        public virtual Smart.Smart Smarts { get; set; }

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

        public virtual RiskLevel RiskLevel { get; set; }
        public virtual Crisis Crisis { get; set; }

        public virtual Service Serivce { get; set; }

        //Program If Program == SMART, refer to smart.
        public virtual Program Program { get; set; }

        public string RiskAccessmentAssignedTo{ get; set; }

        public virtual RiskStatus RiskStatus { get; set; }

        public virtual AssignedWorker AssignedWorker { get; set; }

        public virtual ReferralSource ReferralSource { get; set; }
        public virtual ReferralContact ReferralContact { get; set; }

        public virtual Incident Incident { get; set; }
        public string AbuserSurname { get; set; }
        public string AbuserFirstName { get; set; }
        public virtual AbuserRelationship Relationship { get; set; }

        public virtual Victim VictimOfIncident { get; set; }

        public virtual FamilyViolenceFile File { get; set; }
        //char Gender //(M, F, Trans) Lookup too??
        public char Gender { get; set; }

        public virtual Ethnicity Race { get; set; }

        public virtual Age age { get; set; }
       
        //Yes or null. Need to check if same fiscal year
        public virtual RepeatClient Repeat { get; set; }
        
        //Yes or null. Need to check if same fiscal year
        public virtual DuplicateFile DuplicateFile { get; set; }
        public int NumChildrenAgeZeroSix { get; set; }
        public int NumChildrenAgeSevenTweleve { get; set; }
        public int NumChildrenAgeTeens { get; set; }
       
        //Reopen; Closed; Open
        public virtual FileStatus FileStatuse { get; set; }
        public virtual DateTime DateLastTransfer { get; set; }
        public virtual DateTime DateClosed { get; set; }
        public virtual DateTime DateReopened { get; set; }
    }
}