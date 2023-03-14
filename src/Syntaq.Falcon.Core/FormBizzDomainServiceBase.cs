using Abp.Domain.Services;

namespace FormBizz
{
    public abstract class FormBizzDomainServiceBase : DomainService
    {
        /* Add your common members for all your domain services. */

        protected FormBizzDomainServiceBase()
        {
            LocalizationSourceName = FormBizzConsts.LocalizationSourceName;
        }
    }
}
