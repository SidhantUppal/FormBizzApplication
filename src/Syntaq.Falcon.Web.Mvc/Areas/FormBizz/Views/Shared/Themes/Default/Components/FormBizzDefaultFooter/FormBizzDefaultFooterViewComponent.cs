using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Areas.FormBizz.Models.Layout;
using FormBizz.Web.Session;
using FormBizz.Web.Views;

namespace FormBizz.Web.Areas.FormBizz.Views.Shared.Themes.Default.Components.FormBizzDefaultFooter
{
    public class FormBizzDefaultFooterViewComponent : FormBizzViewComponent
    {
        private readonly IPerRequestSessionCache _sessionCache;

        public FormBizzDefaultFooterViewComponent(IPerRequestSessionCache sessionCache)
        {
            _sessionCache = sessionCache;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var footerModel = new FooterViewModel
            {
                LoginInformations = await _sessionCache.GetCurrentLoginInformationsAsync()
            };

            return View(footerModel);
        }
    }
}
