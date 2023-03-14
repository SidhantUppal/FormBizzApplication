using Abp.Extensions;

namespace FormBizz.Configuration
{
    public class AzureKeyVaultConfiguration
    {
        public bool IsEnabled { get; set; }

        public string KeyVaultName { get; set; }
    }
}