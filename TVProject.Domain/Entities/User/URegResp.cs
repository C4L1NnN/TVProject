﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TVProject.Domain.Entities.User
{
    public class URegResp
    {
        public bool Status { get; set; }
        public string StatusMsg { get; set; }

        public string ErrorMessage { get; set; }
    }
}
