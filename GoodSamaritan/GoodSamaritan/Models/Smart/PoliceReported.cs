﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class PoliceReported
    {
        public int PoliceReportedId { get; set; }
        public string PoliceReportedValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}