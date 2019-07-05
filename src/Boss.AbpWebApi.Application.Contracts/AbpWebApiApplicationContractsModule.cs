using Volo.Abp.Application;
using Volo.Abp.Modularity;

namespace Boss.AbpWebApi.Application.Contracts
{
    [DependsOn(typeof(AbpDddApplicationModule))]
    public class AbpWebApiApplicationContractsModule : AbpModule
    {
    }
}
