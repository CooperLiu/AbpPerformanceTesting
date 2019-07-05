using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.OrderCenter.EntityFrameworkCore
{
    [ConnectionStringName("OrderCenter")]
    public class OrderCenterDbContext : AbpDbContext<OrderCenterDbContext>, IOrderCenterDbContext
    {
        public static string TablePrefix { get; set; } = OrderCenterConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = OrderCenterConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public OrderCenterDbContext(DbContextOptions<OrderCenterDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureOrderCenter(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}