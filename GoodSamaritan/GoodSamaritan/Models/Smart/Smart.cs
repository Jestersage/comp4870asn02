using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class Smart
    {
        //Foreign Key to Client
        public int ClientId { get; set; }

        //SexWorkExploitation LOOKUP //Yes, No, N/A
        //MultiplePerpetrators LOOKUP //Yes. No N/A
        //DrugFacilitatedAssault Lookup //Yes No N/A
        public City CityAssault { get; set; }
        public City CityResidence { get; set; }
        public int AccompanimentMinutes { get; set; }
        public Hospital ReferringHospital { get; set; }
        public Hospital HospitalAttended { get; set; }
        //Social Work Attendance LOOKUP y/n/na
        //Police Attendance Lookup y/n/na
        //Victim Services Attendance Lookup
        //Medical Only
        //Evidence Stored
        //HIV Meds
        //Referred to CBVS y/n/pvbs/na
        //Police Reported
        //Third Party Report
        //Bad Date Report
        public int NumTransportProvided { get; set; }
        public bool ReferToNurse { get; set; }
    }
}