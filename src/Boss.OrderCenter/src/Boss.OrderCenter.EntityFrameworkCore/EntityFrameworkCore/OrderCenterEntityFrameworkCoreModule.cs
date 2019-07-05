using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.OrderCenter.EntityFrameworkCore
{
    [DependsOn(
        typeof(OrderCenterDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class OrderCenterEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<OrderCenterDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}