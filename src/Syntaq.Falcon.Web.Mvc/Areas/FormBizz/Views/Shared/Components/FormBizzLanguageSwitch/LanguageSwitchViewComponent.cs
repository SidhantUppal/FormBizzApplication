using System.Linq;
using System.Threading.Tasks;
using Abp.Localization;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Areas.FormBizz.Models.Layout;
using FormBizz.Web.Views;

namespace FormBizz.Web.Areas.FormBizz.Views.Shared.Components.FormBizzLanguageSwitch
{
    public class FormBizzLanguageSwitchViewComponent : FormBizzViewComponent
    {
        private readonly ILanguageManager _languageManager;

        public FormBizzLanguageSwitchViewComponent(ILanguageManager languageManager)
        {
            _languageManager = languageManager;
        }

        public Task<IViewComponentResult> InvokeAsync(string cssClass)
        {
            var model = new LanguageSwitchViewModel
            {
                Languages = _languageManager.GetActiveLanguages().ToList(),
                CurrentLanguage = _languageManager.CurrentLanguage,
                CssClass = cssClass
            };
            
            return Task.FromResult<IViewComponentResult>(View(model));
        }
    }
}
