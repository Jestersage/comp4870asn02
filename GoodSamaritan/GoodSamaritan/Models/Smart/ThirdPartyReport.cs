﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class ThirdPartyReport
    {
        public int ThirdPartyReportId { get; set; }
        public string ThirdPartyReportValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}