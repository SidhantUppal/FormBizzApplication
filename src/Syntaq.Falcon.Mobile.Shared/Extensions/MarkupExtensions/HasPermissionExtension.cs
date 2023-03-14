using System;
using Syntaq.Falcon.Core;
using Syntaq.Falcon.Core.Dependency;
using Syntaq.Falcon.Services.Permission;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syntaq.Falcon.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class HasPermissionExtension : IMarkupExtension
    {
        public string Text { get; set; }
        
        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return false;
            }

            var permissionService = DependencyResolver.Resolve<IPermissionService>();
            return permissionService.HasPermission(Text);
        }
    }
}