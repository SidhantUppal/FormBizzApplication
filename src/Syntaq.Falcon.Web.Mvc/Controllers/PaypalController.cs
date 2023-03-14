using System;
using System.Threading.Tasks;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Mvc;
using FormBizz.MultiTenancy.Payments;
using FormBizz.MultiTenancy.Payments.Paypal;
using FormBizz.MultiTenancy.Payments.PayPal;
using FormBizz.Web.Models.Paypal;

namespace FormBizz.Web.Controllers
{
    public class PayPalController : FormBizzControllerBase
    {
        private readonly PayPalPaymentGatewayConfiguration _payPalConfiguration;
        private readonly ISubscriptionPaymentRepository _subscriptionPaymentRepository;
        private readonly IPayPalPaymentAppService _payPalPaymentAppService;

        public PayPalController(
            PayPalPaymentGatewayConfiguration payPalConfiguration,
            ISubscriptionPaymentRepository subscriptionPaymentRepository, 
            IPayPalPaymentAppService payPalPaymentAppService)
        {
            _payPalConfiguration = payPalConfiguration;
            _subscriptionPaymentRepository = subscriptionPaymentRepository;
            _payPalPaymentAppService = payPalPaymentAppService;
            _payPalConfiguration = payPalConfiguration;
        }

        public async Task<ActionResult> Purchase(long paymentId, int? tenantId)
        {
            if (tenantId.HasValue)
            {
                SetTenantIdCookie(tenantId);
            }
            
            var payment = await _subscriptionPaymentRepository.GetAsync(paymentId);
            if (payment.Status != SubscriptionPaymentStatus.NotPaid)
            {
                throw new ApplicationException("This payment is processed before");
            }

            if (payment.IsRecurring)
            {
                throw new ApplicationException("PayPal integration doesn't support recurring payments !");
            }

            var model = new PayPalPurchaseViewModel
            {
                PaymentId = payment.Id,
                Amount = payment.Amount,
                Description = payment.Description,
                Configuration = _payPalConfiguration
            };

            return View(model);
        }

        [HttpPost]
        public async Task<ActionResult> ConfirmPayment(long paymentId, string paypalOrderId)
        {
            try
            {
                await _payPalPaymentAppService.ConfirmPayment(paymentId, paypalOrderId);
            
                var returnUrl = await GetSuccessUrlAsync(paymentId);
                return Redirect(returnUrl);
            }
            catch (Exception exception)
            {
                Logger.Error(exception.Message, exception);

                var returnUrl = await GetErrorUrlAsync(paymentId);
                return Redirect(returnUrl);
            }
        }
    }
}