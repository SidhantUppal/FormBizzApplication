using System.Collections.Generic;
using Abp.Notifications;

namespace FormBizz.Web.Areas.FormBizz.Models.Notifications
{
    public class CreateMassNotificationViewModel
    {
        public List<string> TargetNotifiers { get; set; }
    
        public NotificationSeverity Severity { get; set; }
    }
}