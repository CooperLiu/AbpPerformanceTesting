using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsDomainSharedModule)
        )]
    public class ClouldItemsDomainModule : AbpModule
    {

    }
}
