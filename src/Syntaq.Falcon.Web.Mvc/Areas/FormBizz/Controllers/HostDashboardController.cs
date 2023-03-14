using Abp.AspNetCore.Mvc.Authorization;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Authorization;
using FormBizz.DashboardCustomization;
using System.Threading.Tasks;
using FormBizz.Web.Areas.FormBizz.Startup;

namespace FormBizz.Web.Areas.FormBizz.Controllers
{
    [Area("FormBizz")]
    [AbpMvcAuthorize(AppPermissions.Pages_Administration_Host_Dashboard)]
    public class HostDashboardController : CustomizableDashboardControllerBase
    {
        public HostDashboardController(
            DashboardViewConfiguration dashboardViewConfiguration,
            IDashboardCustomizationAppService dashboardCustomizationAppService)
            : base(dashboardViewConfiguration, dashboardCustomizationAppService)
        {

        }

        public async Task<ActionResult> Index()
        {
            return await GetView(FormBizzDashboardCustomizationConsts.DashboardNames.DefaultHostDashboard);
        }
    }
}