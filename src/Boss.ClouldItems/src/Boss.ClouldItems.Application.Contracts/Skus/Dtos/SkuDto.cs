using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;

namespace Boss.ClouldItems.Skus.Dtos
{
    public class SkuUpdateInput
    {
        public string Name { get; set; }

        public string Ename { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public string Barcode { get; set; }

        public decimal NetWeight { get; set; }

        public decimal GrossWeight { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }
    }

    public class SkuCreateInput
    {
        public string Name { get; set; }

        public string Ename { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public string Barcode { get; set; }

        public decimal NetWeight { get; set; }

        public decimal GrossWeight { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }
    }

    public class GetSkuPagedListInput : PagedAndSortedResultRequestDto
    {
        public string Filter { get; set; }
    }

    public class SkuQueryDto : CreationAuditedEntityDto<Guid>
    {
        public string Name { get; set; }

        public string Ename { get; set; }

        public string Description { get; set; }

        public string Code { get; set; }

        public string Barcode { get; set; }

        public decimal NetWeight { get; set; }

        public decimal GrossWeight { get; set; }

        public string Unit { get; set; }

        public decimal Price { get; set; }
    }
}
