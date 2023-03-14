using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FormBizz.Authorization.Permissions.Dto;

namespace FormBizz.Authorization.Permissions
{
    public interface IPermissionAppService : IApplicationService
    {
        ListResultDto<FlatPermissionWithLevelDto> GetAllPermissions();
    }
}
