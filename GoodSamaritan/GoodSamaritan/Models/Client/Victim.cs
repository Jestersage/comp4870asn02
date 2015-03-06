using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class Victim
    {
        public int VictimId {get; set;}
        //primary or secondary
        public string Type { get; set; }

        public virtual ICollection<Client> Clients { get; set; }
    }
}