using Abp.AutoMapper;
using Syntaq.Falcon.Organizations.Dto;

namespace Syntaq.Falcon.Models.Users
{
    [AutoMapFrom(typeof(OrganizationUnitDto))]
    public class OrganizationUnitModel : OrganizationUnitDto
    {
        public bool IsAssigned { get; set; }
    }
}