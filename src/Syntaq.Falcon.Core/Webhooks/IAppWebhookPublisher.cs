using System.Threading.Tasks;
using FormBizz.Authorization.Users;

namespace FormBizz.WebHooks
{
    public interface IAppWebhookPublisher
    {
        Task PublishTestWebhook();
    }
}
