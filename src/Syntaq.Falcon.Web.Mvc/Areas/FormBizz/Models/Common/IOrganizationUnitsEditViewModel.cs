using System.Collections.Generic;
using FormBizz.Organizations.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Common
{
    public interface IOrganizationUnitsEditViewModel
    {
        List<OrganizationUnitDto> AllOrganizationUnits { get; set; }

        List<string> MemberedOrganizationUnits { get; set; }
    }
}