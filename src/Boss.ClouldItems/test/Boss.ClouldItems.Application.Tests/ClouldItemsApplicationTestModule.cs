using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsApplicationModule),
        typeof(ClouldItemsDomainTestModule)
        )]
    public class ClouldItemsApplicationTestModule : AbpModule
    {

    }
}
