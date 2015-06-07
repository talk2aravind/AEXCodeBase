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
        public ActionResult BRC()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCCalendar()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCApplication()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCLevel1()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCLevel2()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCLevel3()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCLevel4()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }

        public ActionResult BRCLevel5()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCLevel6()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BRCLevel7()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }

        public ActionResult BCC()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BCCCalendar()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BCCApplication()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }

        public ActionResult Contactus()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
        public ActionResult BCCInstructorForm()
        {
            ViewBag.Message = "Your Fundraising page.";

            return View();
        }
       
    }
}