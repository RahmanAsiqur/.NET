﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class ProjectsController : Controller
    {
        // GET: Projects
        public ActionResult List()
        {
            return View();
        }
    }
}