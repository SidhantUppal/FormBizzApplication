using Abp.Application.Services.Dto;
using Abp.Authorization;
using Abp.Collections.Extensions;
using Abp.Domain.Repositories;
using Abp.Extensions;
using FormBizz.Authorization;
using FormBizz.Persons;
using FormBizz.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBizz.Persons 
{
    [AbpAuthorize(AppPermissions.Pages_PhoneBook)]
    public class PersonAppService : FormBizzAppServiceBase, IPersonAppService
    {
        private readonly IRepository<Person> _personpository;

        public PersonAppService(IRepository<Person> personpository)
        {
            _personpository = personpository;
        }

        // Get all the person with filter applying here
        public ListResultDto<PersonListDto> GetPersons(GetPersonInput input)
        {
            var persons = _personpository
                .GetAll()
                .WhereIf( 
                    !input.Filter.IsNullOrEmpty(),
                    p => p.Name.Contains(input.Filter) ||
                            p.Surname.Contains(input.Filter) ||
                            p.EmailAddress.Contains(input.Filter)
                )
                .Take(50) // We can add pagination here
                .OrderBy(p => p.Name)
                .ThenBy(p => p.Surname)
                .ToList();

            return new ListResultDto<PersonListDto>(ObjectMapper.Map<List<PersonListDto>>(persons));
        }

        [AbpAuthorize(AppPermissions.Pages_PhoneBook_Create)]
        // Insert Custmer 
        public async Task CreatePerson(CreatePersonInput input)
        {
            var person = ObjectMapper.Map<Person>(input);
            await _personpository.InsertAsync(person);
        }

        // Delete person
        [AbpAuthorize(AppPermissions.Pages_PhoneBook_Delete)]
        public async Task DeletePerson(EntityDto input)
        {
            await _personpository.DeleteAsync(input.Id);
        }

        // For Edit
        [AbpAuthorize(AppPermissions.Pages_PhoneBook_Edit)]
        public async Task<GetPersonForEditOutput> GetPersonForEdit(NullableIdDto input)
        {
            PersonEditDto personEditDto = new PersonEditDto();
            try
            {
                if (input.Id.HasValue) // Editing existing person
                {
                    Person person = _personpository.Get(input.Id.Value);
                    //personEditDto = ObjectMapper.Map<PersonEditDto>(person); // TODO
                    personEditDto = new PersonEditDto { Id = person.Id, EmailAddress = person.EmailAddress, Name = person.Name, Surname = person.Surname };
                }
            }
            catch(Exception ex)
            {

            }

            return new GetPersonForEditOutput
            { 
                Person = personEditDto
            };
        }
    }
}
