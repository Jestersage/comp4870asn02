using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class CityRes
    {
        public int CityResId { get; set; }
        public string CityResName { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}