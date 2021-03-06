﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class Age
    {
        public int AgeId { get; set; }
        public string AgeRange { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}