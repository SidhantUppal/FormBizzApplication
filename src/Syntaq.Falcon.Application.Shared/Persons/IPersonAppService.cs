using Abp.Application.Services;
using Abp.Application.Services.Dto;
using FormBizz.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FormBizz.Persons
{
    // Interface for person module / operations
    public interface IPersonAppService : IApplicationService
    { 
        // Get all Person
        ListResultDto<PersonListDto> GetPersons(GetPersonInput input);
         
        // Create new person 
        Task CreatePerson(CreatePersonInput input);

        // Delete Person 
        Task DeletePerson(EntityDto input);

        // Get person by an id 
        Task<GetPersonForEditOutput> GetPersonForEdit(NullableIdDto input);
    }
}
