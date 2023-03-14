using System.Collections.Generic;
using FormBizz.Caching.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.Maintenance
{
    public class MaintenanceViewModel
    {
        public IReadOnlyList<CacheDto> Caches { get; set; }
    }
}