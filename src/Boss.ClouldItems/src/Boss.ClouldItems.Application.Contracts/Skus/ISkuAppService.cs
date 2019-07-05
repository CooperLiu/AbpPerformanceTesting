using System;
using System.Threading.Tasks;
using Boss.ClouldItems.Skus.Dtos;
using JetBrains.Annotations;
using Volo.Abp.Application.Services;

namespace Boss.ClouldItems.Skus
{
    public interface ISkuAppService : IAsyncCrudAppService<SkuQueryDto, Guid, GetSkuPagedListInput, SkuCreateInput, SkuUpdateInput>
    {
        Task<SkuQueryDto> GetCacheAsync([NotNull] string code);
    }
}