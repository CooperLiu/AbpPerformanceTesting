using Boss.AbpWebApi.Application.Contracts;
using Volo.Abp.Modularity;

namespace Boss.AbpWebApi.Application
{
    [DependsOn(typeof(AbpWebApiApplicationContractsModule))]
    public class AbpWebApiApplicationModule : AbpModule
    {
    }
}
