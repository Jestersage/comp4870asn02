using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class EvidenceStored
    {

        public int EvidenceStoredId { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}