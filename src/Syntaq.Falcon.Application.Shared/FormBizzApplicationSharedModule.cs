using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FormBizz
{
    [DependsOn(typeof(FormBizzCoreSharedModule))]
    public class FormBizzApplicationSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormBizzApplicationSharedModule).GetAssembly());
        }
    }
}