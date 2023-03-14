using System.Threading.Tasks;
using Abp.Application.Services;
using FormBizz.Configuration.Tenants.Dto;

namespace FormBizz.Configuration.Tenants
{
    public interface ITenantSettingsAppService : IApplicationService
    {
        Task<TenantSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(TenantSettingsEditDto input);

        Task ClearLogo();

        Task ClearCustomCss();
    }
}
