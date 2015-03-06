using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class FileStatus
    {
        public int FileStatusId { get; set; }
        public string Status { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}