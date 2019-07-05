using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;

namespace Boss.OrderCenter
{
    [DependsOn(
        typeof(OrderCenterDomainModule),
        typeof(OrderCenterApplicationContractsModule),
        typeof(AbpAutoMapperModule)
        )]
    public class OrderCenterApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                /* Using `true` for the `validate` parameter to
                 * validate the profile on application startup.
                 * See http://docs.automapper.org/en/stable/Configuration-validation.html for more info
                 * about the configuration validation. */
                options.AddProfile<OrderCenterApplicationAutoMapperProfile>(validate: true);
            });
        }
    }
}
