using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using KendoWebApplication1.Models.Charts;

namespace KendoWebApplication1.Controllers
{
    public class ChartsController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult CallsByCountry()
        {
            var data = GenerateData()
                .OrderBy(x => x.Date);

            return Json(data, JsonRequestBehavior.AllowGet);
        }

        private IEnumerable<CallByCountry> GenerateData()
        {
            var data = new List<CallByCountry>
            {
                new CallByCountry
                {
                    Month = 7,
                    Year = 2015,
                    Country = "USA",
                    CallsCount = 5
                },
                //new CallByCountry
                //{
                //    Month = 8,
                //    Year = 2015,
                //    Country = "USA",
                //    CallsCount = 3
                //},
                new CallByCountry
                {
                    Month = 8,
                    Year = 2015,
                    Country = "UK",
                    CallsCount = 9
                },
                new CallByCountry
                {
                    Month = 7,
                    Year = 2015,
                    Country = "UK",
                    CallsCount = 11
                }
            };

            return data;
        }
    }
}