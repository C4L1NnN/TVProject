﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TVProject.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // About
        public ActionResult About()
        {
            return View();
        }

        // Treatment
        public ActionResult Treatment()
        {
            return View();
        }
    }
}