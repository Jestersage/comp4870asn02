using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class RiskStatus
    {
        public int RiskStatusId { get; set; }

        //Pending; Complete; null
        public string RiskStatusValue { get; set; }
    }
}