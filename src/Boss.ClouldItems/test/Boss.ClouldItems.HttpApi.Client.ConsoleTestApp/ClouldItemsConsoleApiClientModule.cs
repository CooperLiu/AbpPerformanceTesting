using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ClouldItemsConsoleApiClientModule : AbpModule
    {
        
    }
}
