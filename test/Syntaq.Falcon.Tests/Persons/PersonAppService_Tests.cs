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
    public class PersonAppService_Tests : PersonAppServiceTestBase
    {
        protected readonly IPersonAppService _personAppService;

        public PersonAppService_Tests()
        {
            _personAppService = Resolve<IPersonAppService>();
        }

        [Fact]
        public void Should_Get_All_People_Without_Any_Filter()
        {
            //Act
            var persons = _personAppService.GetPersons(new GetPersonInput());

            //Assert
            persons.Items.Count.ShouldBe(2);
        }

        [Fact]
        public void Should_Get_People_With_Filter()
        {
            //Act
            var persons = _personAppService.GetPersons(
                new GetPersonInput
                {
                    Filter = "Sidhant"
                });

            //Assert
            persons.Items.Count.ShouldBe(1);
            persons.Items[0].Name.ShouldBe("saunak");
            persons.Items[0].Surname.ShouldBe("saha");
        }
    }
}
