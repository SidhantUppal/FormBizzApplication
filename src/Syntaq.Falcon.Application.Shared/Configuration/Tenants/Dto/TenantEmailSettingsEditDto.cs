using Abp.Auditing;
using FormBizz.Configuration.Dto;

namespace FormBizz.Configuration.Tenants.Dto
{
    public class TenantEmailSettingsEditDto : EmailSettingsEditDto
    {
        public bool UseHostDefaultEmailSettings { get; set; }
    }
}