using FormBizz.Customers;
using FormBizz.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBizz.Tests.Persons
{
    // Used for Person App Service Test Base
    public abstract class PersonAppServiceTestBase : AppTestBase
    {
        protected readonly IPersonAppService CustomerAppService;

        protected PersonAppServiceTestBase()
        {
            CustomerAppService = Resolve<IPersonAppService>();
        }

        // Create test Person 
        protected void CreateTestCustomer()
        {
            // Note: There is a default "admin" person also

            UsingDbContext(
                context =>
                {
                    context.Persons.Add(CreatePersonEntity("Saunak", "Saha", "saunaktlgt@gmail.com"));
                    context.Persons.Add(CreatePersonEntity("Bjarke", "Larsen", "bjarke@syntaq.com"));
                });
        }

        // Created Cutomer entity here
        protected Person CreatePersonEntity(string name, string surname, string emailAddress)
        {
            var person = new Person
            {
                EmailAddress = emailAddress,
                Name = name,
                Surname = surname
            };

            return person;
        }
    }
}
