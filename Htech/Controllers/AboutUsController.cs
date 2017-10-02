using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Htech.Controllers
{
    public class AboutUsController : Controller
    {
        // GET: AboutUs
        public ActionResult TheCompany()
        {
            return View();
        }
        public ActionResult PartnersandSponsors()
        {
            return View();
        }
        public ActionResult ClientsandCollaborators()
        {
            return View();
        }
        public ActionResult Careers()
        {
            return View();
        }
    }
}