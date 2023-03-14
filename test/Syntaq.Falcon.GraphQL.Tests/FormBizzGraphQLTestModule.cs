using Abp.Modules;
using Abp.Reflection.Extensions;
using Castle.Windsor.MsDependencyInjection;
using Microsoft.Extensions.DependencyInjection;
using FormBizz.Configure;
using FormBizz.Startup;
using FormBizz.Test.Base;

namespace FormBizz.GraphQL.Tests
{
    [DependsOn(
        typeof(FormBizzGraphQLModule),
        typeof(FormBizzTestBaseModule))]
    public class FormBizzGraphQLTestModule : AbpModule
    {
        public override void PreInitialize()
        {
            IServiceCollection services = new ServiceCollection();
            
            services.AddAndConfigureGraphQL();

            WindsorRegistrationHelper.CreateServiceProvider(IocManager.IocContainer, services);
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(FormBizzGraphQLTestModule).GetAssembly());
        }
    }
}