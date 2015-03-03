using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class FiscalYear
    {
        public int FiscalYearId { get; set; }

        //10-11; 11-12; 12-13; 13-14; 14-15; 15-16; 16-17
        public string FiscalYearName { get; set; }
    }
}