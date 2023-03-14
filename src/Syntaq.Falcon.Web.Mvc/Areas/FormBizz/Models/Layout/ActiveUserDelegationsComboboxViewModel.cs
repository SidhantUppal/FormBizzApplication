using System.Collections.Generic;
using FormBizz.Authorization.Delegation;
using FormBizz.Authorization.Users.Delegation.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Layout
{
    public class ActiveUserDelegationsComboboxViewModel
    {
        public IUserDelegationConfiguration UserDelegationConfiguration { get; set; }

        public List<UserDelegationDto> UserDelegations { get; set; }

        public string CssClass { get; set; }
    }
}
