using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class ClouldItemsHttpApiModule : AbpModule
    {
        
    }
}
