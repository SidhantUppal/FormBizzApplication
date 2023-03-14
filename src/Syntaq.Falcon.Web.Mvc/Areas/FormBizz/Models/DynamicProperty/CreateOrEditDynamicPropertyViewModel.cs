using System.Collections.Generic;
using FormBizz.DynamicEntityProperties.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.DynamicProperty
{
    public class CreateOrEditDynamicPropertyViewModel
    {
        public DynamicPropertyDto DynamicPropertyDto { get; set; }

        public List<string> AllowedInputTypes { get; set; }
    }
}
