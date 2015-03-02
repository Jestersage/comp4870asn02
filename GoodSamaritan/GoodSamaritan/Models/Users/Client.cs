using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Users
{
    public class Client
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ClientId { get; set; }

        //FiscalYear Lookup

        //int Month
        //int Day
        //string Surname
        //string FirstName
        //string PoliceFileNum
        //int CourtFileNum
        //int SWCFileNum

        //RiskLevel LOOKUP
        //Crisis LOOKUP
        //Service LOOKUP
        //Program LOOKUP
        //RiskAccessmentAssignedTo LOOKUP

    }
}