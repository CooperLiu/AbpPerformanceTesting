using System;
using System.Threading;
using System.Threading.Tasks;
using Boss.ClouldItems.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Volo.Abp;
using Volo.Abp.Domain.Repositories.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace Boss.ClouldItems
{
    public class EfCoreSkuRepository : EfCoreRepository<ClouldItemsDbContext, Sku, Guid>, ISkuRepository
    {
        public EfCoreSkuRepository(IDbContextProvider<ClouldItemsDbContext> dbContextProvider) : base(dbContextProvider)
        {
        }

        public async Task<Sku> FindByCode(string code, CancellationToken cancellationToken = default)
        {
            Check.NotNullOrEmpty(code, nameof(code));

            return await DbSet.FirstOrDefaultAsync(s => s.Code == code, cancellationToken: cancellationToken);
        }
    }
}
