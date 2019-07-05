using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class OrderCenterHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "OrderCenter";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(OrderCenterApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
