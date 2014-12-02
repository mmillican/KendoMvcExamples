using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Kendo.Mvc.Extensions;
using Kendo.Mvc.UI;
using KendoWebApplication1.Models.Scheduler;

namespace KendoWebApplication1.Controllers
{
    public class SchedulerController : Controller
    {
        // GET: Scheduler
        public ActionResult Index()
        {
            var model = new SchedulerViewModel();


            return View(model);
        }

        [HttpPost]
        public ActionResult GetData([DataSourceRequest] DataSourceRequest request)
        {
            var data = new List<TaskViewModel>
                {
                    new TaskViewModel
                        {
                            Start = new DateTime(2014, 12, 1, 8, 0, 0),
                            End = new DateTime(2014, 12, 1, 17, 0, 0),
                            Title = "Task 1"
                        }
                };

            return Json(data.ToDataSourceResult(request));
        }
    }
}