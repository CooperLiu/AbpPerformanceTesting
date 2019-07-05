using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.ClouldItems.EntityFrameworkCore
{
    [ConnectionStringName("ClouldItems")]
    public class ClouldItemsDbContext : AbpDbContext<ClouldItemsDbContext>, IClouldItemsDbContext
    {
        public static string TablePrefix { get; set; } = ClouldItemsConsts.DefaultDbTablePrefix;

        public static string Schema { get; set; } = ClouldItemsConsts.DefaultDbSchema;

        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public DbSet<Sku> Skus { get; set; }

        public ClouldItemsDbContext(DbContextOptions<ClouldItemsDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureClouldItems(options =>
            {
                options.TablePrefix = TablePrefix;
                options.Schema = Schema;
            });
        }
    }
}