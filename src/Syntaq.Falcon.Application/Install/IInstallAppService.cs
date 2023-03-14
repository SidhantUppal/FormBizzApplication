using System.Threading.Tasks;
using Abp.Application.Services;
using FormBizz.Install.Dto;

namespace FormBizz.Install
{
    public interface IInstallAppService : IApplicationService
    {
        Task Setup(InstallDto input);

        AppSettingsJsonDto GetAppSettingsJson();

        CheckDatabaseOutput CheckDatabase();
    }
}