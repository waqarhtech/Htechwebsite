using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Htech.Controllers
{
    public class CompanyController : Controller
    {
        // GET: Company
        public ActionResult OverviewAboutus()
        {
            return View();
        }
        public ActionResult Contactus()
        {
            return View();
        }
        public ActionResult OurPatners()
        {
            return View();
        }
        public ActionResult Other()
        {
            return View();
        }
    }
}