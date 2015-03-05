using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class Smart
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int SmartId { get; set; }
        //Foreign Key to Client
        public int ClientId { get; set; }

        public SexWorkExploitation Exploitation { get; set; } //Yes, No, N/A
        public MultiplePerpetrator MultiPerp {get;set;} //Yes. No N/A
        public DrugFacilitatedAssault DrugAssault { get; set; } //Yes No N/A
        public City CityAssault { get; set; }
        public City CityResidence { get; set; }
        public int AccompanimentMinutes { get; set; }
        public Hospital ReferringHospital { get; set; }
        public Hospital HospitalAttended { get; set; }
        public SocialWorkAttendance SocialWorkAttendence { get; set; }//y/n/na
        public PoliceAttendance PoliceAttendence {get;set;} //Lookup y/n/na
        public VictimServicesAttendance VictimServices { get; set; }//Lookup
        public MedicalOnly MedicalOnly { get; set; }
        public EvidenceStored Evidence { get; set; }
        public HIVMeds HIVMeds { get; set; }
        public ReferCBVS ReferCBVS { get; set; }//y/n/pvbs/na
        public PoliceReported PoliceReported { get; set; }
        public ThirdPartyReport ThirdParty { get; set; }

        public BadDateReport BadDate { get; set; }
        public int NumTransportProvided { get; set; }
        public bool ReferToNurse { get; set; }
    }
}