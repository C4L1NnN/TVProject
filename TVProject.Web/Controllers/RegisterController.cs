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

                URegData data = new URegData
                {
                    Credential = model.Credential,
                    Password = model.Password,
                    Email = model.Email,
                    ConfirmPassword = model.ConfirmPassword,
                    RegDateTime = model.RegDateTime,
                    RegIp = model.RegIp,
                };

                var userReg = _session.UserReg(data);
                if (userReg.Status)
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            // If invalid, return view with model to display errors
            return View(model);
        }
    }

}
