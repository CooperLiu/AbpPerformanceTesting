using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.ClouldItems.EntityFrameworkCore
{
    [ConnectionStringName("ClouldItems")]
    public interface IClouldItemsDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */

        DbSet<Sku> Skus { get; set; }

    }
}