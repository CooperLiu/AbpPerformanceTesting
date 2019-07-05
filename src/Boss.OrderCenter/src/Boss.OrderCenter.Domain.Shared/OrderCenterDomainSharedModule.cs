using Volo.Abp.Modularity;
using Volo.Abp.Localization;
using Boss.OrderCenter.Localization;
using Volo.Abp.Localization.ExceptionHandling;
using Volo.Abp.Localization.Resources.AbpValidation;
using Volo.Abp.VirtualFileSystem;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(AbpLocalizationModule)
    )]
    public class OrderCenterDomainSharedModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<VirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<OrderCenterDomainSharedModule>();
            });

            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Add<OrderCenterResource>("en")
                    .AddBaseTypes(typeof(AbpValidationResource))
                    .AddVirtualJson("/Localization/OrderCenter/DomainShared");
            });

            Configure<ExceptionLocalizationOptions>(options =>
            {
                options.MapCodeNamespace("OrderCenter", typeof(OrderCenterResource));
            });
        }
    }
}
