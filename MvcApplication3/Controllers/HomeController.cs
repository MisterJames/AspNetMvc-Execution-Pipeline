using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication3.Controllers
{
    public class HomeController : Controller
    {
        private int _myCounter = 0;

        public HomeController()
        {
            MvcApplication.ConstructorCallCount++;
        }

        public ActionResult ExecutionCount()
        {
            return View(++_myCounter);
        }
        
        public PartialViewResult ExecutionCountAsPartial()
        {
            return PartialView(++_myCounter);
        }

        [OutputCache(NoStore=true, Duration=1)]
        public PartialViewResult ExecutionCountAsPartialViaAjax()
        {
            return PartialView("ExecutionCountAsPartial", ++_myCounter);
        }

        [SimpleActionFilter]
        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            Debug.WriteLine("Action (method) executing");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


    }
}
