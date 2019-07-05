using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class OrderCenterConsoleApiClientModule : AbpModule
    {
        
    }
}
