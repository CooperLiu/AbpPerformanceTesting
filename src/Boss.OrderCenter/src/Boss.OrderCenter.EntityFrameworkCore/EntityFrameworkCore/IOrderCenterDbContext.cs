using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.OrderCenter.EntityFrameworkCore
{
    [ConnectionStringName("OrderCenter")]
    public interface IOrderCenterDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}