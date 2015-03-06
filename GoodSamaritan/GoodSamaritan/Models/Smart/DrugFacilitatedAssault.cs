using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class DrugFacilitatedAssault
    {
        public int DrugFacilitatedAssaultId { get; set; }
        public string Value { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}