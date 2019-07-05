using System;
using System.Linq;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;

namespace Boss.ClouldItems
{
    public class SkuDataSeedContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly ISkuRepository _skuRepository;

        public SkuDataSeedContributor(ISkuRepository skuRepository)
        {
            _skuRepository = skuRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (_skuRepository.Any())
            {
                return;
            }
            for (int i = 1; i <= 10; i++)
            {
                var sku = new Sku();
                sku.Code = "SKU" + i;
                sku.Name = "SKUNAME"+i;
                sku.Barcode = DateTime.Now.Ticks.ToString();
                sku.Description = $"SKU-{i}-Description";
                sku.Ename = "SKUENAME" + i;
                sku.GrossWeight = i;
                sku.NetWeight = i;
                sku.Price = 10.00M + i;
                sku.Unit = "件";

                await _skuRepository.InsertAsync(sku);
            }
        }
    }
}
