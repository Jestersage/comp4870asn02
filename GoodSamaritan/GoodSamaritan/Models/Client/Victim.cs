using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class Victim
    {
        public int VictimId {get; set;}
        //primary or secondary
        public string VictimType { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}