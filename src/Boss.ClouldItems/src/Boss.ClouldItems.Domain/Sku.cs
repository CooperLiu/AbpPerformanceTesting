using System;
using Volo.Abp.Auditing;
using Volo.Abp.Domain.Entities.Auditing;

namespace Boss.ClouldItems
{
    public class Sku : CreationAuditedAggregateRoot<Guid>, IHasModificationTime
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

        public DateTime? LastModificationTime { get; set; }
    }
}
