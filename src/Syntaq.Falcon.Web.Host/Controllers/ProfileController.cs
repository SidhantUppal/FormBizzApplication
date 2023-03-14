using Abp.AspNetCore.Mvc.Authorization;
using FormBizz.Authorization.Users.Profile;
using FormBizz.Graphics;
using FormBizz.Storage;

namespace FormBizz.Web.Controllers
{
    [AbpMvcAuthorize]
    public class ProfileController : ProfileControllerBase
    {
        public ProfileController(
            ITempFileCacheManager tempFileCacheManager,
            IProfileAppService profileAppService,
            IImageFormatValidator imageFormatValidator) :
            base(tempFileCacheManager, profileAppService, imageFormatValidator)
        {
        }
    }
}