using Boss.ClouldItems.Localization;
using Volo.Abp.Application;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class ClouldItemsApplicationContractsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<ClouldItemsApplicationContractsModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<ClouldItemsResource>()
                    .AddVirtualJson("/Localization/ClouldItems/ApplicationContracts");
            });
        }
    }
}
