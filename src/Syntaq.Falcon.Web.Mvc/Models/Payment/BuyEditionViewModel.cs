using System.Collections.Generic;
using FormBizz.Editions;
using FormBizz.Editions.Dto;
using FormBizz.MultiTenancy.Payments;
using FormBizz.MultiTenancy.Payments.Dto;

namespace FormBizz.Web.Models.Payment
{
    public class BuyEditionViewModel
    {
        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public decimal? AdditionalPrice { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }

        public List<PaymentGatewayModel> PaymentGateways { get; set; }
    }
}
