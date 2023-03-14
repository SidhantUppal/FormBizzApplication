using System;
using Abp.AutoMapper;
using Syntaq.Falcon.Sessions.Dto;

namespace Syntaq.Falcon.Models.Common
{
    [AutoMapFrom(typeof(ApplicationInfoDto)),
     AutoMapTo(typeof(ApplicationInfoDto))]
    public class ApplicationInfoPersistanceModel
    {
        public string Version { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}