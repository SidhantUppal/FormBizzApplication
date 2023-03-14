using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Syntaq.Falcon
{
    public class FalconClientModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FalconClientModule).GetAssembly());
        }
    }
}
