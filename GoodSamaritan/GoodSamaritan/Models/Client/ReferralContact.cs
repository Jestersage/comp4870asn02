using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class ReferralContact
    {
        public int ReferralContactId {get; set;}

        //PBVS; MCFD; PBVS; VictimLINK; TH; Self; FNS; Other; Medical
        public string ReferralContactName {get;set;}
        public virtual ICollection<Client> Clients { get; set; }
    }
}