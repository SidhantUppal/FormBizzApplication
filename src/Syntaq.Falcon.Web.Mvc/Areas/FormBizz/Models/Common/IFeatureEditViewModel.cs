using System.Collections.Generic;
using Abp.Application.Services.Dto;
using FormBizz.Editions.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Common
{
    public interface IFeatureEditViewModel
    {
        List<NameValueDto> FeatureValues { get; set; }

        List<FlatFeatureDto> Features { get; set; }
    }
}