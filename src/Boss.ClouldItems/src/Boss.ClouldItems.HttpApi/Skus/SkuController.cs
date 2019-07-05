using System;
using System.Threading.Tasks;
using Boss.ClouldItems.Skus.Dtos;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp;
using Volo.Abp.Application.Dtos;

namespace Boss.ClouldItems.Skus
{
    [RemoteService()]
    [Route("api/ClouldItems")]
    public class SkuController : ClouldItemsController, ISkuAppService
    {
        private readonly ISkuAppService _skuAppService;

        public SkuController(ISkuAppService skuAppService)
        {
            _skuAppService = skuAppService;
        }


        [HttpGet]
        public async Task<SkuQueryDto> GetAsync(Guid id)
        {
            return await _skuAppService.GetAsync(id);
        }

        [HttpGet]
        [Route("pagedList")]
        public async Task<PagedResultDto<SkuQueryDto>> GetListAsync(GetSkuPagedListInput input)
        {
            return await _skuAppService.GetListAsync(input);
        }

        [HttpPost]
        public async Task<SkuQueryDto> CreateAsync(SkuCreateInput input)
        {
            return await _skuAppService.CreateAsync(input);
        }

        [HttpPut]
        public async Task<SkuQueryDto> UpdateAsync(Guid id, SkuUpdateInput input)
        {
            return await _skuAppService.UpdateAsync(id, input);
        }

        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await _skuAppService.DeleteAsync(id);
        }
    }
}
