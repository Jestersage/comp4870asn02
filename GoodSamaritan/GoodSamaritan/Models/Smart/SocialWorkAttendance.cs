using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class SocialWorkAttendance
    {
        public int SocialWorkAttendanceId { get; set; }
        public string SocialWorkAttendanceValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}