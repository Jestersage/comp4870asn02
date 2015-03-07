using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class VictimServicesAttendance
    {
        public int VictimServicesAttendanceId { get; set; }
        public string VictimServicesAttendanceValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}