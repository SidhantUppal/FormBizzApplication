using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;

namespace FormBizz.Startup
{
    [DependsOn(typeof(FormBizzCoreModule))]
    public class FormBizzGraphQLModule : AbpModule
    {
        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormBizzGraphQLModule).GetAssembly());
        }

        public override void PreInitialize()
        {
            base.PreInitialize();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }
    }
}