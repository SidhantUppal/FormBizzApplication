using Abp.AutoMapper;
using FormBizz.MultiTenancy;
using FormBizz.MultiTenancy.Dto;
using FormBizz.Web.Areas.FormBizz.Models.Common;

namespace FormBizz.Web.Areas.FormBizz.Models.Tenants
{
    [AutoMapFrom(typeof (GetTenantFeaturesEditOutput))]
    public class TenantFeaturesEditViewModel : GetTenantFeaturesEditOutput, IFeatureEditViewModel
    {
        public Tenant Tenant { get; set; }
    }
}