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

        //FiscalYear Lookup
        //int Month
        //int Day
        public string Surname { get; set; }
        public string FirstName { get; set; }

        //Format: 99-99999, or null
        public string PoliceFileNum { get; set; }
        
        //nullable
        public int CourtFileNum { get; set; }
        public int SWCFileNum { get; set; }

        //RiskLevel LOOKUP
        //Crisis LOOKUP
        //Service LOOKUP
        //Program LOOKUP

        //string RiskAccessmentAssignedTo

        //RiskStatus LOOKUP
        //AssignedWork LOOKUP
        //ReferralSource LOOKUP
        //ReferralContact LOOKUP
        
        //Incident LOOKUP
        //string AbuserSurname
        //string AbuserFirstName
        //AbuserRelationship LOOKUP
        //VictimOfIncident  LOOKUP
        //FamilyViolenceFile  LOOKUP
        //char Gender //(M, F, Trans)
        //Ethnicity LOOKUP
        //Age LOOKUP
        //RepeatClient LOOKUP //Yes or null. Need to check if same fiscal year
        //DuplicateFile LOOKUP //Yes or null. Need to check if same fiscal year
        public int NumChildrenAgeZeroSix { get; set; }
        public int NumChildrenAgeSevenTweleve { get; set; }
        //int NumChildrenAgeTeens 
        //FileStatus LOOKUP //Reopen; Closed; Open
        //DateTime DateLastTransfer 
        //DateTime DateClosed
        //DateTime DateReopened
    }
}