using Abp.AutoMapper;
using FormBizz.Localization.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Languages
{
    [AutoMapFrom(typeof(GetLanguageForEditOutput))]
    public class CreateOrEditLanguageModalViewModel : GetLanguageForEditOutput
    {
        public bool IsEditMode => Language.Id.HasValue;
    }
}