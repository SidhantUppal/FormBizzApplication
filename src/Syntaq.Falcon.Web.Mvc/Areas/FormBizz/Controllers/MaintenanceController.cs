using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Authorization;
using FormBizz.Caching;
using FormBizz.Web.Areas.FormBizz.Models.Maintenance;
using FormBizz.Web.Controllers;

namespace FormBizz.Web.Areas.FormBizz.Controllers
{
    [Area("FormBizz")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Maintenance)]
    public class MaintenanceController : FormBizzControllerBase
    {
        private readonly ICachingAppService _cachingAppService;

        public MaintenanceController(ICachingAppService cachingAppService)
        {
            _cachingAppService = cachingAppService;
        }

        public ActionResult Index()
        {
            var model = new MaintenanceViewModel
            {
                Caches = _cachingAppService.GetAllCaches().Items
            };

            return View(model);
        }
    }
}