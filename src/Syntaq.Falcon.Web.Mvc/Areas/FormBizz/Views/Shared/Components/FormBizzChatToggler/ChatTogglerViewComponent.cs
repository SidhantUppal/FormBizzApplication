using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FormBizz.Web.Areas.FormBizz.Models.Layout;
using FormBizz.Web.Views;

namespace FormBizz.Web.Areas.FormBizz.Views.Shared.Components.FormBizzChatToggler
{
    public class FormBizzChatTogglerViewComponent : FormBizzViewComponent
    {
        public Task<IViewComponentResult> InvokeAsync(string cssClass, string iconClass = "flaticon-chat-2 fs-2")
        {
            return Task.FromResult<IViewComponentResult>(View(new ChatTogglerViewModel
            {
                CssClass = cssClass,
                IconClass = iconClass
            }));
        }
    }
}
