using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Boss.ClouldItems
{
    [DependsOn(
        typeof(ClouldItemsDomainModule),
        typeof(ClouldItemsApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class ClouldItemsApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                /* Using `true` for the `validate` parameter to
                 * validate the profile on application startup.
                 * See http://docs.automapper.org/en/stable/Configuration-validation.html for more info
                 * about the configuration validation. */
                options.AddProfile<ClouldItemsApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
