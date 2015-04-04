using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class Ethnicity
    {
        public int EthnicityId { get; set; }
        public string Ethnictiy { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}