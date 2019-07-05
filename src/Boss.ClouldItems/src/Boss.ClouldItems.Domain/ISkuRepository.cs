using System;
using System.Threading;
using System.Threading.Tasks;
using JetBrains.Annotations;
using Volo.Abp.Domain.Repositories;

namespace Boss.ClouldItems
{
    public interface ISkuRepository : IRepository<Sku, Guid>
    {
        Task<Sku> FindByCode([NotNull] string code, CancellationToken cancellationToken = default);
    }
}