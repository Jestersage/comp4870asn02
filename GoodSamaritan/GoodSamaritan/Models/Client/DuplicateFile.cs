﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class DuplicateFile
    {
        public int DuplicateFileId { get; set; }
        public string IsDuplicate { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}