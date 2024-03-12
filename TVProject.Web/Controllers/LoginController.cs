using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TVProject.BusinessLogic;
using TVProject.BusinessLogic.Interfaces;
using TVProject.Domain.Entities.User;
using TVProject.Web.Models;

namespace TVProject.Web.Controllers
{
    public class LoginController : Controller
    {
        private readonly ISession _session;
        public LoginController()
        {
            var bl = new BussinesLogic();
            _session = bl.GetSessionBL();
        }
        
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(UserLogin login)
        {
            if (ModelState.IsValid)
            {
                /*                ULoginData data = new ULoginData
                                {
                                    Credential = login.Credential,
                                    Password = login.Password,
                                    LoginIP = login.LoginIP,
                                    LoginDataTime = DateTime.Now,
                                };

                                var userLogin = _session.UserLogin(data);
                                if (userLogin.Status)
                                {
                                    //ADD COOKIE

                                    return RedirectToAction("Index", "Home");
                                }
                                else
                                {
                                    ModelState.AddModelError("", userLogin.StatusMsg);
                                    return View();  
                                }*/

                // Check if the provided credentials are valid
                if (login.Credential == "User1" && login.Password == "user")
                {
                    // Authentication successful, redirect to home page
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    // Invalid credentials, add an error message
                    ModelState.AddModelError("", "Incorrect username or password");
                }
            }

            return View(login);
        }

    }

}