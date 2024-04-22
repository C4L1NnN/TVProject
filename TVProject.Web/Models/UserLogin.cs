using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TVProject.Web.Models
{
    public class UserLogin
    {
        [Required]
        [Display(Name = "Username of Email")]
        public string Credential { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]

        public string Password { get; set; }


        [Display(Name = "Login IP")]
        public string LoginIP { get; set; }
    }
}