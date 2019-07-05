using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Boss.ClouldItems.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.VirtualFileSystem;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(AbpLocalizationModule)
    )]
    public class ClouldItemsDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<ClouldItemsDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<ClouldItemsResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/ClouldItems/DomainShared");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("ClouldItems", typeof(ClouldItemsResource));
            });
        }
    }
}
