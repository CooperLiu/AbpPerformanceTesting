using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class ClouldItemsHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "ClouldItems";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(ClouldItemsApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
