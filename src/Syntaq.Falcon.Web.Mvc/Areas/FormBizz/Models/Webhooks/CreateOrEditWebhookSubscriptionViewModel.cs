using Abp.Application.Services.Dto;
using Abp.Webhooks;
using FormBizz.WebHooks.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Webhooks
{
    public class CreateOrEditWebhookSubscriptionViewModel
    {
        public WebhookSubscription WebhookSubscription { get; set; }

        public ListResultDto<GetAllAvailableWebhooksOutput> AvailableWebhookEvents { get; set; }
    }
}
