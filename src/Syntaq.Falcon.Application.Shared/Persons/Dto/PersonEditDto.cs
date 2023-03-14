using System;
using System.Collections.Generic;
using System.Text;

namespace FormBizz.Persons.Dto
{
    public class PersonEditDto
    {
        public int? Id { get; set; }
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }
    }
}
