using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using FormBizz.Authorization.Users;
using FormBizz.MultiTenancy;

namespace FormBizz.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}