using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace B3nCr.Communication.Controllers
{
    public class SecuredController : Controller
    {
        // GET: Secured
        [Authorize]
        public ActionResult Index()
        {
            return View((User as ClaimsPrincipal).Claims);
        }
    }
}