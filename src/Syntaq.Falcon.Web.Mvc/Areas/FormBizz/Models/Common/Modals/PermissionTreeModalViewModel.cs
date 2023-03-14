using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormBizz.Authorization.Permissions.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Common.Modals
{
    public class PermissionTreeModalViewModel : IPermissionsEditViewModel
    {
        public List<FlatPermissionDto> Permissions { get; set; }
        public List<string> GrantedPermissionNames { get; set; }
    }
}
