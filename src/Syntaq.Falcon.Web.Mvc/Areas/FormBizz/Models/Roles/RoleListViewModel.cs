using System.Collections.Generic;
using Abp.Application.Services.Dto;
using FormBizz.Authorization.Permissions.Dto;
using FormBizz.Web.Areas.FormBizz.Models.Common;

namespace FormBizz.Web.Areas.FormBizz.Models.Roles
{
    public class RoleListViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}