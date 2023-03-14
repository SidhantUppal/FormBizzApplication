using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FormBizz
{
    public class FormBizzCoreSharedModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormBizzCoreSharedModule).GetAssembly());
        }
    }
}