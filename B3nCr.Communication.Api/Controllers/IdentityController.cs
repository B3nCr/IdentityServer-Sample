using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;

namespace B3nCr.Communication.Api.Controllers
{
    public class IdentityController : ApiController
    {
        [Authorize]
        [EnableCors("https://b3ncr.comms:44341", "*", "*")]
        public IHttpActionResult Get()
        {
            var user = User as ClaimsPrincipal;
            var claims = from c in user.Claims
                         select new
                         {
                             type = c.Type,
                             value = c.Value
                         };

            return Json(claims);
        }
    }
}