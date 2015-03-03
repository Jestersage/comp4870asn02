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

        public FiscalYear FiscalYear { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }
        public string Surname { get; set; }
        public string FirstName { get; set; }

        //Format: 99-99999, or null
        public string PoliceFileNum { get; set; }
        
        //nullable
        public int CourtFileNum { get; set; }
        public int SWCFileNum { get; set; }

        public RiskLevel RiskLevel { get; set; }
        //Crisis LOOKUP
        //Service LOOKUP
        //Program LOOKUP

        public string RiskAccessmentAssignedTo{ get; set; }

        //RiskStatus LOOKUP
        //AssignedWork LOOKUP
        //ReferralSource LOOKUP
        //ReferralContact LOOKUP
        
        //Incident LOOKUP
        public string AbuserSurname { get; set; }
        public string AbuserFirstName { get; set; }
        //AbuserRelationship LOOKUP
        //VictimOfIncident  LOOKUP
        //FamilyViolenceFile  LOOKUP
        //char Gender //(M, F, Trans) Lookup too??
        //Ethnicity LOOKUP
        //Age LOOKUP
        //RepeatClient LOOKUP //Yes or null. Need to check if same fiscal year
        //DuplicateFile LOOKUP //Yes or null. Need to check if same fiscal year
        public int NumChildrenAgeZeroSix { get; set; }
        public int NumChildrenAgeSevenTweleve { get; set; }
        public int NumChildrenAgeTeens { get; set; }
        //FileStatus LOOKUP //Reopen; Closed; Open
        public DateTime DateLastTransfer { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReopened { get; set; }
    }
}