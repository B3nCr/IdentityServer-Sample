using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B3nCr.Auth
{
    public class RegistrationModel
    {
        public string ConfirmPassword { get; set; }

        public string Password { get; set; }

        public string EmailAddress { get; set; }
    }
}
