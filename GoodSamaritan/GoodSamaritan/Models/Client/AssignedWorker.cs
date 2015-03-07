using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class AssignedWorker
    {
        public int AssignedWorkerId { get; set; }

        //Michelle; Tyra; Louise; Angela; Dave; Troy; Michael; Manpreet; Patrick; None
        public string AssignedWorkerName { get; set; }
        public virtual ICollection<Client> Clients { get; set; }
    }
}