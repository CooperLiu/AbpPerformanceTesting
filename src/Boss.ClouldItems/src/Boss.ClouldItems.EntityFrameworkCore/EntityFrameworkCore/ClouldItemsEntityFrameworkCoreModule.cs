using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Boss.ClouldItems.EntityFrameworkCore
{
    [DependsOn(
        typeof(ClouldItemsDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class ClouldItemsEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ClouldItemsDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
            });
        }
    }
}