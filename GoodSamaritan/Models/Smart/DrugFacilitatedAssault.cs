using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GoodSamaritan.Models.Smart
{
    [Authorize(Roles = "Administrator")]
    public class DrugFacilitatedAssault
    {
        public int DrugFacilitatedAssaultId { get; set; }
        public string DrugFacilitatedAssaultValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}