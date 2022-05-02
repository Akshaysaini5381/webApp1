using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using webApp1.Dbprofile;

namespace webApp1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {






            PROFILEEntities obj = new PROFILEEntities();
            var obj1 = obj.EMPLOYEE2.ToList();
            ViewBag.name = "chhavi";
            ViewBag.name1 = "sonu";
            ViewBag.name2 = "pushpa";
            ViewBag.name3 = "jaani";




            ViewData["name"] = "deep";
            ViewData["number"] = 123;
            ViewData["float"] = 12.3;

            ViewBag.name = new List<int>()
            {
                1,
                2,
                3,
                5
            };

            ViewData["name"] = new List<string>()
            {
               "upasana aulakh",
                "chhavi",
                 "justin",
                 "upasana"

            };



            TempData["names"] = new List<string>()
            {
               "abc",
                "cdb",
                 "ert",
                 "upasana"

            };

            TempData["name"] = "deep";
            TempData["number"] = 123;
            TempData["float"] = 12.3;
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}