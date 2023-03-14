using Abp.Dependency;
using GraphQL.Types;
using GraphQL.Utilities;
using FormBizz.Queries.Container;
using System;

namespace FormBizz.Schemas
{
    public class MainSchema : Schema, ITransientDependency
    {
        public MainSchema(IServiceProvider provider) :
            base(provider)
        {
            Query = provider.GetRequiredService<QueryContainer>();
        }
    }
}