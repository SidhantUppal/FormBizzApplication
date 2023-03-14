using Abp.Application.Services.Dto;
using System;
using System.Collections.Generic;
using System.Text;

namespace FormBizz.Persons.Dto
{
    // DTO for person list {Client interaction}
    public class PersonListDto : EntityDto
    { 
        public string Name { get; set; }

        public string Surname { get; set; }

        public string EmailAddress { get; set; }
    }
}
