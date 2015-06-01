using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AEXApplication.Controllers
{
 
    [RequireHttps]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
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
        public ActionResult Donate()
        {
            ViewBag.Message = "Your donate page.";

            return View();
        }
        public ActionResult Fundraising()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }

    }
}