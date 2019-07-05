using Boss.OrderCenter.Localization;
using Volo.Abp.Application;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class OrderCenterApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<OrderCenterApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<OrderCenterResource>()
                    .AddVirtualJson("/Localization/OrderCenter/ApplicationContracts");
            });
        }
    }
}
