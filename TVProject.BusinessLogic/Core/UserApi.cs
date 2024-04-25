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
    }
}

