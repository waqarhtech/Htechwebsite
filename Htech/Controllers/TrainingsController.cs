﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Htech.Controllers
{
    public class TrainingsController : Controller
    {
        // GET: Trainings
        public ActionResult fundedtrainings()
        {
            return View();
        }
        public ActionResult nonfundedtrainings()
        {
            return View();
        }
    }
}