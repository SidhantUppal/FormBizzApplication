using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Areas.FormBizz.Models.Layout;
using FormBizz.Web.Session;
using FormBizz.Web.Views;

namespace FormBizz.Web.Areas.FormBizz.Views.Shared.Components.FormBizzLogo
{
    public class FormBizzLogoViewComponent : FormBizzViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public FormBizzLogoViewComponent(
            IPerRequestSessionCache sessionCache
        )
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync(string logoSkin = null, string logoClass = "")
        {
            var headerModel = new LogoViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync(),
                LogoSkinOverride = logoSkin,
                LogoClassOverride = logoClass
            };

            return View(headerModel);
        }
    }
}
