using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class PoliceAttendance
    {
        public int PoliceAttendanceId { get; set; }
        public string PoliceAttendanceValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}