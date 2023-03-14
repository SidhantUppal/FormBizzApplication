using Abp.Runtime.Validation;
using Shouldly;
using FormBizz.Persons;
using FormBizz.Persons.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace FormBizz.Tests.Persons
{
    public class PersonAppService_Create_Tests : PersonAppServiceTestBase
    {
        protected readonly IPersonAppService _personAppService;

        public PersonAppService_Create_Tests()
        {
            _personAppService = Resolve<IPersonAppService>();
        }

        [Fact]
        public async Task Should_Create_Person_With_Valid_Arguments()
        {
            //Act
            await _personAppService.CreatePerson(
                new CreatePersonInput
                {
                    Name = "John",
                    Surname = "Nash",
                    EmailAddress = "john.nash@abeautifulmind.com"
                });

            //Assert
            UsingDbContext(
                context =>
                {
                    var john = context.Persons.FirstOrDefault(p => p.EmailAddress == "john.nash@abeautifulmind.com");
                    john.ShouldNotBe(null);
                    john.Name.ShouldBe("John");
                });
        }

        [Fact]
        public async Task Should_Not_Create_Person_With_Invalid_Arguments()
        {
            //Act and Assert
            await Assert.ThrowsAsync<AbpValidationException>(
                async () =>
                {
                    await _personAppService.CreatePerson(
                new CreatePersonInput 
                {
                    Name = "John"
                });
           });
        }
    }
}
