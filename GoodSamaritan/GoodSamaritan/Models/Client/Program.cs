using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodSamaritan.Models.Client
{
    public class Program
    {
        public int ProgramId { get; set; }
        
        //Crisis; Court; SMART; DVU; MCFD
        //If Program == SMART, ref Smart
        public string ProgramName { get; set; }
    }
}