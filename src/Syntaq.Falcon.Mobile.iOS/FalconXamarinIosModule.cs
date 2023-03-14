using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Syntaq.Falcon
{
    [DependsOn(typeof(FalconXamarinSharedModule))]
    public class FalconXamarinIosModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FalconXamarinIosModule).GetAssembly());
        }
    }
}