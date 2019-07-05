using System;
using Boss.ClouldItems.Skus.Dtos;
using Volo.Abp.Application.Services;

namespace Boss.ClouldItems.Skus
{
    public interface ISkuAppService : IAsyncCrudAppService<SkuQueryDto, Guid, GetSkuPagedListInput, SkuCreateInput, SkuUpdateInput>
    {

    }
}