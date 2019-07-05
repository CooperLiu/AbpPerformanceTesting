using System;
using System.Linq;
using System.Threading.Tasks;
using Boss.ClouldItems.Skus.Dtos;
using JetBrains.Annotations;
using Volo.Abp.Application.Services;
using Volo.Abp.Caching;
using Volo.Abp.ObjectMapping;

namespace Boss.ClouldItems.Skus
{
    public class SkuAppService : AsyncCrudAppService<Sku, SkuQueryDto, Guid, GetSkuPagedListInput, SkuCreateInput, SkuUpdateInput>, ISkuAppService
    {
        private readonly IDistributedCache<SkuQueryDto> _skuCache;
        private readonly ISkuRepository _skuRepository;
        private readonly IObjectMapper _objectMapper;

        public SkuAppService(ISkuRepository repository, IDistributedCache<SkuQueryDto> skuCache, IObjectMapper objectMapper) 
            : base(repository)
        {
            _skuCache = skuCache;
            _objectMapper = objectMapper;
            _skuRepository = repository;
        }

        protected override IQueryable<Sku> CreateFilteredQuery(GetSkuPagedListInput input)
        {
            var query = base.CreateFilteredQuery(input)
                .WhereIf(!input.Filter.IsNullOrEmpty(),
                    s => s.Code.Contains(input.Filter) || s.Name.Contains(input.Filter));

            return query;

        }

        public async Task<SkuQueryDto> GetCacheAsync([NotNull]string code)
        {
            var cacheKey = $"Sku-Cache-{code}";

            var cache = await _skuCache.GetOrAddAsync(cacheKey, async () =>
                {
                    var sku= await _skuRepository.FindByCode(code);
                    var dto = new SkuQueryDto();

                    return _objectMapper.Map(sku, dto);
                });

            return cache;
        }
    }



    
}