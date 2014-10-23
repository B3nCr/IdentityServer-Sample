using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace B3nCr.Auth
{
    public class User
    {
        public User(string emailAddress, string password)
        {
            // TODO: Complete member initialization
            this.EmailAddress = emailAddress;
            this.Password = password;
        }

        public string EmailAddress { get; set; }

        public string Password { get; set; }
    }
}
