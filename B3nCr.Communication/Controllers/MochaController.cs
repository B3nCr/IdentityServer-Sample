#if DEBUG
namespace B3nCr.Communication.Controllers
{
    using System.Web.Mvc;

    public class MochaController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}
#endif
