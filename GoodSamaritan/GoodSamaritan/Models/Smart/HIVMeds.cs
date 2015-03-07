using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class HIVMeds
    {
        public int HIVMedsId { get; set; }
        public string HIVMedsValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}