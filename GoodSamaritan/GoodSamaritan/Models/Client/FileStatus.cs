using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Client
{
    [Authorize(Roles = "Administrator")]
    public class FileStatus
    {
        public int FileStatusId { get; set; }
        public string FileStatusString { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}