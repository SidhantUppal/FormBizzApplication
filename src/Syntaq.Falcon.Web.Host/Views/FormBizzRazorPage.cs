using Abp.AspNetCore.Mvc.Views;

namespace FormBizz.Web.Views
{
    public abstract class FormBizzRazorPage<TModel> : AbpRazorPage<TModel>
    {
        protected FormBizzRazorPage()
        {
            LocalizationSourceName = FormBizzConsts.LocalizationSourceName;
        }
    }
}
