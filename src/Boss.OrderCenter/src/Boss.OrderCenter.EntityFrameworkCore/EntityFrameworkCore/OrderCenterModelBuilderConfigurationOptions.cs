using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Boss.OrderCenter.EntityFrameworkCore
{
    public class OrderCenterModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public OrderCenterModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = OrderCenterConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = OrderCenterConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}