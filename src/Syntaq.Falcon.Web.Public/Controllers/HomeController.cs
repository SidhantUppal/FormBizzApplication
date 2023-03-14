using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Controllers;

namespace FormBizz.Web.Public.Controllers
{
    public class HomeController : FormBizzControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}