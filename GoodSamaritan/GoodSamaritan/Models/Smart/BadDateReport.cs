using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class BadDateReport
    {
        public int BadDateReportId { get; set; }
        public string BadDateReportValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}