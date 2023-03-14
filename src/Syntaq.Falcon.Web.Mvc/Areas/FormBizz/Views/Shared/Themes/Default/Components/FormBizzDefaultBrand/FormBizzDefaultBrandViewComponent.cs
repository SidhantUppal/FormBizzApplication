using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Areas.FormBizz.Models.Layout;
using FormBizz.Web.Session;
using FormBizz.Web.Views;

namespace FormBizz.Web.Areas.FormBizz.Views.Shared.Themes.Default.Components.FormBizzDefaultBrand
{
    public class FormBizzDefaultBrandViewComponent : FormBizzViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public FormBizzDefaultBrandViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var headerModel = new HeaderViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(headerModel);
        }
    }
}
