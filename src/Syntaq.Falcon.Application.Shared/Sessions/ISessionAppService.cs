using System.Threading.Tasks;
using Abp.Application.Services;
using FormBizz.Sessions.Dto;

namespace FormBizz.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();

        Task<UpdateUserSignInTokenOutput> UpdateUserSignInToken();
    }
}
