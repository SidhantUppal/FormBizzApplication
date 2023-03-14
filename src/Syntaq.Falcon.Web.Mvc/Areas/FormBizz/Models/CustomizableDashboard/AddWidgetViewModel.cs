using System.Collections.Generic;
using FormBizz.DashboardCustomization.Dto;

namespace FormBizz.Web.Areas.FormBizz.Models.CustomizableDashboard
{
    public class AddWidgetViewModel
    {
        public List<WidgetOutput> Widgets { get; set; }

        public string DashboardName { get; set; }

        public string PageId { get; set; }
    }
}
