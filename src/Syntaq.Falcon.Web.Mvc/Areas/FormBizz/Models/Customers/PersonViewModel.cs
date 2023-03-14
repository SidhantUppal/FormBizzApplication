using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FormBizz.Persons.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Customers
{
    [AutoMapFrom(typeof(ListResultDto<PersonListDto>))]
    public class PersonViewModel : ListResultDto<PersonListDto>
    {
        public string Filter { get; set; }
    }
}
