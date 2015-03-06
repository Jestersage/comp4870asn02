using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class City
    {
        public int CityId { get; set; }
        public string CityName { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }

    }
}