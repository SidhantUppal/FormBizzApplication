using System;
using Syntaq.Falcon.Core;
using Syntaq.Falcon.Localization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Syntaq.Falcon.Extensions.MarkupExtensions
{
    [ContentProperty("Text")]
    public class TranslateExtension : IMarkupExtension
    {
        public string Text { get; set; }

        public object ProvideValue(IServiceProvider serviceProvider)
        {
            if (ApplicationBootstrapper.AbpBootstrapper == null || Text == null)
            {
                return Text;
            }

            return L.Localize(Text);
        }
    }
}