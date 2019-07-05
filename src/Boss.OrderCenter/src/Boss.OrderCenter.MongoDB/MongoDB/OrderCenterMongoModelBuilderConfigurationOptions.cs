using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Boss.OrderCenter.MongoDB
{
    public class OrderCenterMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public OrderCenterMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = OrderCenterConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}