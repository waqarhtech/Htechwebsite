using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Htech.Controllers
{
    public class EducationalLaboratoriesController : Controller
    {
        // GET: EducationalLaboratories
        public ActionResult EngineeringCollegeLabs()
        {
            return View();
        }
        public ActionResult NetworkingITLabs()
        {
            return View();
        }
        public ActionResult MedicalLabs()
        {
            return View();
        }
        public ActionResult SchoolCollegelabs()
        {
            return View();
        }
    }
}