using Abp.Authorization;
using FormBizz.Authorization.Roles;
using FormBizz.Authorization.Users;

namespace FormBizz.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
