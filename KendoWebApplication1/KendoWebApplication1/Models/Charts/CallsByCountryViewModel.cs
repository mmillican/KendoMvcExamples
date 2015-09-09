using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace KendoWebApplication1.Models.Charts
{
    public class CallsByCountryViewModel
    {
        
    }

    public class CallByCountry
    {
        public int Month { get; set; }
        public int Year { get; set; }
        public string Period { get { return Month + "/" + Year; } }

        public DateTime Date { get { return new DateTime(Year, Month, 1); } }
        public string Country { get; set; }
        public int CallsCount { get; set; }
    }
}