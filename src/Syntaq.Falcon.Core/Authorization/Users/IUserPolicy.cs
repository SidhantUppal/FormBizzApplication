using System.Threading.Tasks;
using Abp.Domain.Policies;

namespace FormBizz.Authorization.Users
{
    public interface IUserPolicy : IPolicy
    {
        Task CheckMaxUserCountAsync(int tenantId);
    }
}
