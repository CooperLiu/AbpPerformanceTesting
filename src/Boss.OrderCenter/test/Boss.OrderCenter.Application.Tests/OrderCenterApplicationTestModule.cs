using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterApplicationModule),
        typeof(OrderCenterDomainTestModule)
        )]
    public class OrderCenterApplicationTestModule : AbpModule
    {

    }
}
