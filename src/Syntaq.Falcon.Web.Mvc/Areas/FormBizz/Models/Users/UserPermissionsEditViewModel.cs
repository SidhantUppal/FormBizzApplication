using Abp.AutoMapper;
using FormBizz.Authorization.Users;
using FormBizz.Authorization.Users.Dto;
using FormBizz.Web.Areas.FormBizz.Models.Common;

namespace FormBizz.Web.Areas.FormBizz.Models.Users
{
    [AutoMapFrom(typeof(GetUserPermissionsForEditOutput))]
    public class UserPermissionsEditViewModel : GetUserPermissionsForEditOutput, IPermissionsEditViewModel
    {
        public User User { get; set; }
    }
}