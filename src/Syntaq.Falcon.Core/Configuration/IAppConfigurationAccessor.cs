using Microsoft.Extensions.Configuration;

namespace FormBizz.Configuration
{
    public interface IAppConfigurationAccessor
    {
        IConfigurationRoot Configuration { get; }
    }
}
