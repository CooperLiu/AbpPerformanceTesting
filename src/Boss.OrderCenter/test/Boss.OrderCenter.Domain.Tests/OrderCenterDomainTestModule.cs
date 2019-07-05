using Boss.OrderCenter.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(OrderCenterEntityFrameworkCoreTestModule)
        )]
    public class OrderCenterDomainTestModule : AbpModule
    {
        
    }
}
