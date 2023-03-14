using System.Collections.Generic;
using FormBizz.Authorization.Permissions.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }

        List<string> GrantedPermissionNames { get; set; }
    }
}