using System.Collections.Generic;
using FormBizz.Editions.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Tenants
{
    public class TenantIndexViewModel
    {
        public List<SubscribableEditionComboboxItemDto> EditionItems { get; set; }
    }
}