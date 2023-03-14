using FormBizz.Editions;
using FormBizz.Editions.Dto;
using FormBizz.MultiTenancy.Payments;
using FormBizz.Security;
using FormBizz.MultiTenancy.Payments.Dto;

namespace FormBizz.Web.Models.TenantRegistration
{
    public class TenantRegisterViewModel
    {
        public PasswordComplexitySetting PasswordComplexitySetting { get; set; }

        public int? EditionId { get; set; }

        public SubscriptionStartType? SubscriptionStartType { get; set; }

        public EditionSelectDto Edition { get; set; }

        public EditionPaymentType EditionPaymentType { get; set; }
    }
}
