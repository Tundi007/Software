﻿using IAM.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAM.Application.AuthenticationService.ViewModels
{
    public class UserAuthenticationResult
    {
        public User User { get; set; }
        public string Token { get; set; }
    }
}
