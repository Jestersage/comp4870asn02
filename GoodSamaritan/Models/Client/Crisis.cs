using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class Crisis
    {
        public int CrisisId { get; set; }

        //Call; Accompaniment; Drop-In
        public string CrisisName { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}