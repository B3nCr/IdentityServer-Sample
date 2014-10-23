using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B3nCr.Auth
{
    public interface IAuthenticationService
    {
        IEnumerable<User> Users { get; }

        void Register(RegistrationModel model);
    }
}
