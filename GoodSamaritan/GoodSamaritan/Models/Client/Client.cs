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
        public Crisis Crisis { get; set; }

        public Service Serivce { get; set; }

        //Program If Program == SMART, refer to smart.
        public Program Program { get; set; }

        public string RiskAccessmentAssignedTo{ get; set; }

        public RiskStatus RiskStatus { get; set; }

        public AssignedWorker AssignedWorker { get; set; }

        public ReferralSource ReferralSource { get; set; }
        public ReferralContact ReferralContact { get; set; }

        public Incident Incident { get; set; }
        public string AbuserSurname { get; set; }
        public string AbuserFirstName { get; set; }
        public AbuserRelationship Relationship { get; set; }
        
        public Victim VictimOfIncident { get; set; }
        
        public FamilyViolenceFile File {get; set;}
        //char Gender //(M, F, Trans) Lookup too??
        public char Gender { get; set; }
        
        public Ethnicity Race {get;set;}
        
        public Age age { get; set; }
       
        //Yes or null. Need to check if same fiscal year
        public RepeatClient Repeat { get; set; }
        
        //Yes or null. Need to check if same fiscal year
        public DuplicateFile DuplicateFile { get; set; }
        public int NumChildrenAgeZeroSix { get; set; }
        public int NumChildrenAgeSevenTweleve { get; set; }
        public int NumChildrenAgeTeens { get; set; }
       
        //Reopen; Closed; Open
        public FileStatus FileStatuse { get; set; }
        public DateTime DateLastTransfer { get; set; }
        public DateTime DateClosed { get; set; }
        public DateTime DateReopened { get; set; }
    }
}