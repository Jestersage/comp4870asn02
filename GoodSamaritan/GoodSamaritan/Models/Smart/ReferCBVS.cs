using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class ReferCBVS
    {
        public int ReferCBVSId { get; set; }
        public string ReferCBVSValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}