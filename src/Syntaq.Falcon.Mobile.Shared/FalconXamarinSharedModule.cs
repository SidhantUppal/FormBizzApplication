using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace Syntaq.Falcon
{
    [DependsOn(typeof(FalconClientModule), typeof(AbpAutoMapperModule))]
    public class FalconXamarinSharedModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Localization.IsEnabled = false;
            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FalconXamarinSharedModule).GetAssembly());
        }
    }
}