using Abp.AutoMapper;
using FormBizz.MultiTenancy.Dto;

namespace FormBizz.Web.Models.TenantRegistration
{
    [AutoMapFrom(typeof(EditionsSelectOutput))]
    public class EditionsSelectViewModel : EditionsSelectOutput
    {
    }
}
