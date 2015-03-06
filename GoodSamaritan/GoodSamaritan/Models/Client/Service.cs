using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class Service
    {
        public int ServiceId { get; set; }
        //File; N/A 
        //(Defaults to ‘File’ if SWC exists, ‘N/A’ if SWC is blank)
        public string ServiceName { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}