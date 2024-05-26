using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVProject.BusinessLogic.DBModel;
using TVProject.Domain.Entities.User;

namespace TVProject.BusinessLogic.Core
{
    public class UserApi
    {
        internal ULoginResp UserLoginAction(ULoginData data)
        {
            using (var userContext = new UserContext())
            {
                var result = userContext.users.FirstOrDefault(u => u.Username == data.Credential && u.Password == data.Password);
                if (result == null)
                {
                    return new ULoginResp { Status = false };
                }
            }
            return new ULoginResp { Status = true };

        }

        internal URegResp UserRegAction(URegData data)
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
            }
        }

    }
}

