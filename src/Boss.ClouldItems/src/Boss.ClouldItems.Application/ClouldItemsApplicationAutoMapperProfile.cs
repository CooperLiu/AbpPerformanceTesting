using AutoMapper;
using Boss.ClouldItems.Skus.Dtos;

namespace Boss.ClouldItems
{
    public class ClouldItemsApplicationAutoMapperProfile : Profile
    {
        public ClouldItemsApplicationAutoMapperProfile()
        {
            /* You can configure your AutoMapper mapping configuration here.
             * Alternatively, you can split your mapping configurations
             * into multiple profile classes for a better organization. */

            CreateMap<Sku, SkuQueryDto>();
            CreateMap<Sku, SkuCreateInput>().ReverseMap();
            CreateMap<Sku, SkuUpdateInput>().ReverseMap();
        }
    }
}