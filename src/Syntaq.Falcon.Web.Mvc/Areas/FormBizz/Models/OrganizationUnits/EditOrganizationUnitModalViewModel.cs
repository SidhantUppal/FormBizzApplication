using Abp.AutoMapper;
using Abp.Organizations;

namespace FormBizz.Web.Areas.FormBizz.Models.OrganizationUnits
{
    [AutoMapFrom(typeof(OrganizationUnit))]
    public class EditOrganizationUnitModalViewModel
    {
        public long? Id { get; set; }

        public string DisplayName { get; set; }
    }
}