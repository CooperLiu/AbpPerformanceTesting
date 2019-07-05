using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterDomainSharedModule)
        )]
    public class OrderCenterDomainModule : AbpModule
    {

    }
}
