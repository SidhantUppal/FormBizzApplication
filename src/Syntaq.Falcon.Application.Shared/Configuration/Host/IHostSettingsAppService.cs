using System.Threading.Tasks;
using Abp.Application.Services;
using FormBizz.Configuration.Host.Dto;

namespace FormBizz.Configuration.Host
{
    public interface IHostSettingsAppService : IApplicationService
    {
        Task<HostSettingsEditDto> GetAllSettings();

        Task UpdateAllSettings(HostSettingsEditDto input);

        Task SendTestEmail(SendTestEmailInput input);
    }
}
