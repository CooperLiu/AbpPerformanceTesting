using System;
using System.Linq;
using Boss.ClouldItems.Skus.Dtos;
using Volo.Abp.Application.Services;

namespace Boss.ClouldItems.Skus
{
    public class SkuAppService : AsyncCrudAppService<Sku, SkuQueryDto, Guid, GetSkuPagedListInput, SkuCreateInput, SkuUpdateInput>, ISkuAppService
    {
        public SkuAppService(ISkuRepository repository) 
            : base(repository)
        {
        }

        protected override IQueryable<Sku> CreateFilteredQuery(GetSkuPagedListInput input)
        {
            var query = base.CreateFilteredQuery(input)
                .WhereIf(!input.Filter.IsNullOrEmpty(),
                    s => s.Code.Contains(input.Filter) || s.Name.Contains(input.Filter));

            return query;

        }
    }

    
}