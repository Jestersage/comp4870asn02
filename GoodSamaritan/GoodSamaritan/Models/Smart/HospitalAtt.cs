﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class HospitalAtt
    {

        public int HospitalAttId { get; set; }
        public string HospitalAttName { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}