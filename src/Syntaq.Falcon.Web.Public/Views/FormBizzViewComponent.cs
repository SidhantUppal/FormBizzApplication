using Abp.AspNetCore.Mvc.ViewComponents;

namespace FormBizz.Web.Public.Views
{
    public abstract class FormBizzViewComponent : AbpViewComponent
    {
        protected FormBizzViewComponent()
        {
            LocalizationSourceName = FormBizzConsts.LocalizationSourceName;
        }
    }
}