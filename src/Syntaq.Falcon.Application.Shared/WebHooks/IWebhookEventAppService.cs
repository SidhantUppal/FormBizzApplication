using System.Threading.Tasks;
using Abp.Webhooks;

namespace FormBizz.WebHooks
{
    public interface IWebhookEventAppService
    {
        Task<WebhookEvent> Get(string id);
    }
}
