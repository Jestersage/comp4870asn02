﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class FamilyViolenceFile
    {
        public int FamilyViolenceFileId { get; set; }
        //Yes; No or N/A
        public string Status { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}