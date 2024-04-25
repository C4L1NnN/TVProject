using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVProject.BusinessLogic.DBModel;
using TVProject.BusinessLogic.Interfaces;
using TVProject.BusinessLogic;
using TVProject.Domain.Entities.User;


namespace TVProject.Web.Controllers
{
    public class RegisterController : Controller
    {

        // GET: Register
        private readonly ISession _session;
        public RegisterController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        // GET: Login
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Index(URegData model)
        {
            if (ModelState.IsValid)
            {
                using (var userContext = new UserContext())
                {
                    // Check for duplicate usernames
                    if (userContext.users.Any(u => u.Username == model.Credential))
                    {
                        ModelState.AddModelError("Username", "Username already exists.");
                        return View(model);
                    }

                    var user = new UDbTable
                    {
                        Username = model.Credential,
                        Password = model.Password,
                        Email = model.Email,
                        LastLogin = DateTime.UtcNow,
                        LasIp = Request.UserHostAddress,
                    };
                    userContext.users.Add(user);
                    userContext.SaveChanges();

                    // Redirect or display success message
                    return RedirectToAction("Index", "Home"); // Example redirect
                }
            }
            // If invalid, return view with model to display errors
            return View(model);
        }
    }

}
