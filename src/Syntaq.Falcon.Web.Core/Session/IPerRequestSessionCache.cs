using System.Threading.Tasks;
using FormBizz.Sessions.Dto;

namespace FormBizz.Web.Session
{
    public interface IPerRequestSessionCache
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformationsAsync();
    }
}
