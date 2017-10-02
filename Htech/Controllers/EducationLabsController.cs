using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Htech.Controllers
{
    public class EducationLabsController : Controller
    {
        // GET: EducationLabs
        public ActionResult ElectricalandElectronicsEngineeringLabs()
        {
            return View();
        }
        public ActionResult MechanicalandCivilEngineeringLabs()
        {
            return View();
        }
        public ActionResult SchoolandCollegeLabs()
        {
            return View();
        }
    }
}