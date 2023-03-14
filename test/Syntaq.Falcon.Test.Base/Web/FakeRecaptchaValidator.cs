using System.Threading.Tasks;
using FormBizz.Security.Recaptcha;

namespace FormBizz.Test.Base.Web
{
    public class FakeRecaptchaValidator : IRecaptchaValidator
    {
        public Task ValidateAsync(string captchaResponse)
        {
            return Task.CompletedTask;
        }
    }
}
