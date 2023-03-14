using Abp.AutoMapper;
using FormBizz.Authorization.Permissions.Dto;
using FormBizz.Persons.Dto;
using FormBizz.Web.Areas.FormBizz.Models.Common;
using System.Collections.Generic;

namespace FormBizz.Web.Areas.FormBizz.Models.Customers
{
    [AutoMapFrom(typeof(GetPersonForEditOutput))]
    public class CreateOrEditPersonModalViewModel : GetPersonForEditOutput//, IPermissionsEditViewModel
    {
        public bool IsEditMode => Person.Id.HasValue;

        //public List<FlatPermissionDto> Permissions { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
        //public List<string> GrantedPermissionNames { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }
    }
}
