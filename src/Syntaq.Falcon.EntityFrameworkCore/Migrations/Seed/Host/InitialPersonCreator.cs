using FormBizz.EntityFrameworkCore;
using FormBizz.Persons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormBizz.Migrations.Seed.Host
{
    public class InitialPersonCreator
    {
        private readonly FormBizzDbContext _context;

        public InitialPersonCreator(FormBizzDbContext context)
        {
            _context = context; 
        }

        public void Create()
        {
            var douglas = _context.Persons.FirstOrDefault(p => p.EmailAddress == "saunaktlgt@gmail.com");
            if (douglas == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Saunak",
                        Surname = "Saha",
                        EmailAddress = "saunaktlgt@gmail.com"
                    });
            }

            var asimov = _context.Persons.FirstOrDefault(p => p.EmailAddress == "bjarke@syntaq.com");
            if (asimov == null)
            {
                _context.Persons.Add(
                    new Person
                    {
                        Name = "Bjarke",
                        Surname = "Larsen",
                        EmailAddress = "bjarke@syntaq.com"
                    });
            }
        }
    }
}