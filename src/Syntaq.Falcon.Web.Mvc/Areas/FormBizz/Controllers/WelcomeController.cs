using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Controllers;

namespace FormBizz.Web.Areas.FormBizz.Controllers
{
    [Area("FormBizz")]
    [AbpMvcAuthorize]
    public class WelcomeController : FormBizzControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
    }
}