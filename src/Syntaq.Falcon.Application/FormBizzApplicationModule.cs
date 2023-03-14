using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using FormBizz.Authorization;

namespace FormBizz
{
    /// <summary>
    /// Application layer module of the application.
    /// </summary>
    [DependsOn(
        typeof(FormBizzApplicationSharedModule),
        typeof(FormBizzCoreModule)
        )]
    public class FormBizzApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            //Adding authorization providers
            Configuration.Authorization.Providers.Add<AppAuthorizationProvider>();

            //Adding custom AutoMapper configuration
            Configuration.Modules.AbpAutoMapper().Configurators.Add(CustomDtoMapper.CreateMappings);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormBizzApplicationModule).GetAssembly());
        }
    }
}