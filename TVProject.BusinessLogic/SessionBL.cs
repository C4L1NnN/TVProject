using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TVProject.BusinessLogic.Core;
using TVProject.BusinessLogic.Interfaces;
using TVProject.Domain.Entities.User;

namespace TVProject.BusinessLogic
{
    public class SessionBL : UserApi, ISession
    {
        public ULoginResp UserLogin(ULoginData data)
        {
            return UserLoginAction(data);
        }

        public URegResp UserReg(URegData data)
        {
            return UserRegAction(data);
        }
    }

}
