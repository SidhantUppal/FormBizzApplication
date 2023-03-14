using System.Collections.Generic;
using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using FormBizz.Editions.Dto;
using FormBizz.Web.Areas.FormBizz.Models.Common;

namespace FormBizz.Web.Areas.FormBizz.Models.Editions
{
    [AutoMapFrom(typeof(GetEditionEditOutput))]
    public class EditEditionModalViewModel : GetEditionEditOutput, IFeatureEditViewModel
    {
        public bool IsEditMode => Edition.Id.HasValue;

        public IReadOnlyList<ComboboxItemDto> EditionItems { get; set; }

        public IReadOnlyList<ComboboxItemDto> FreeEditionItems { get; set; }
    }
}