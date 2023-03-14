using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FormBizz.Common.Dto;
using FormBizz.Editions.Dto;

namespace FormBizz.Common
{
    public interface ICommonLookupAppService : IApplicationService
    {
        Task<ListResultDto<SubscribableEditionComboboxItemDto>> GetEditionsForCombobox(bool onlyFreeItems = false);

        Task<PagedResultDto<NameValueDto>> FindUsers(FindUsersInput input);

        GetDefaultEditionNameOutput GetDefaultEditionName();
    }
}