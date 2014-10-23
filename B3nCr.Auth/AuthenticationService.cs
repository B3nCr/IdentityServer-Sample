using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3nCr.Auth
{
    public class AuthenticationService : IAuthenticationService
    {
        private ICollection<User> users = new List<User>();

        public IEnumerable<User> Users { get { return users.AsEnumerable(); } }

        public void Register(RegistrationModel model)
        {
            users.Add(new User(model.EmailAddress, model.Password));
        }
    }
}
