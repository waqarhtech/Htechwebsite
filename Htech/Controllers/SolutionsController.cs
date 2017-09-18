using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Htech.Controllers
{
    public class SolutionsController : Controller
    {
        // GET: Solutions
        public ActionResult EducationalSolutions()
        {
            return View();
        }
        public ActionResult Techandsol()
        {
            return View();
        }
    }
  
}