using System.Collections.Generic;
using FormBizz.Authorization.Permissions.Dto;

namespace FormBizz.Authorization.Users.Dto
{
    public class GetUserPermissionsForEditOutput
    {
        public List<FlatPermissionDto> Permissions { get; set; }

        public List<string> GrantedPermissionNames { get; set; }
    }
}