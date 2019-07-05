using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class OrderCenterHttpApiModule : AbpModule
    {
        
    }
}
