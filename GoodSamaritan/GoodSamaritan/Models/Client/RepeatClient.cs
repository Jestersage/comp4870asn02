using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class RepeatClient
    {
        public int RepeatClientId { get; set; }
        public string Repeat { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}