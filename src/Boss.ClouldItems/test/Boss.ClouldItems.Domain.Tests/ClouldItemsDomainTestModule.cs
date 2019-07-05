using Boss.ClouldItems.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    /* Domain tests are configured to use the EF Core provider.
     * You can switch to MongoDB, however your domain tests should be
     * database independent anyway.
     */
    [DependsOn(
        typeof(ClouldItemsEntityFrameworkCoreTestModule)
        )]
    public class ClouldItemsDomainTestModule : AbpModule
    {
        
    }
}
