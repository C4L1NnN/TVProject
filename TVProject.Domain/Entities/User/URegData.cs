using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProject.Domain.Entities.User
{
    public class URegData
    {
        public string Credential { get; set; }
        public string Password { get; set; }

        public string Email { get; set; }

        public string ConfirmPassword { get; set; }
        public string LoginIp { get; set; }
        public DateTime RegDateTime { get; set; }

    }
}
