using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Boss.OrderCenter.MongoDB
{
    public static class OrderCenterMongoDbContextExtensions
    {
        public static void ConfigureOrderCenter(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new OrderCenterMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}