using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVProject.Web.Models;

namespace TVProject.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
/*            UserData u = new UserData();
            u.Username = "User1";
            u.Password = "user";


            return View(u);*/
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