using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class ReferralSource
    {
        public int ReferralSourceId { get; set; }
        public string Source { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}