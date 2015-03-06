using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class Age
    {
        public int AgeId { get; set; }
        public string AgeRange { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}