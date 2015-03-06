using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class RiskLevel
    {
        public int RiskLevelId { get; set; }

        public string RiskLevelValue { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
        //High; DVU; null
    }
}