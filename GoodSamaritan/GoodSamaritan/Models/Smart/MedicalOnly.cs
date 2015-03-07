﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Smart
{
    public class MedicalOnly
    {
        public int MedicalOnlyId { get; set; }
        public string MedicalOnlyValue { get; set; }
        public virtual ICollection<Smart> Smarts { get; set; }
    }
}