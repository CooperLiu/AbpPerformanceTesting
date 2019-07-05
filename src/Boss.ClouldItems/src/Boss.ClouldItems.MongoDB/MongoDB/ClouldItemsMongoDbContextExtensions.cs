using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace Boss.ClouldItems.MongoDB
{
    public static class ClouldItemsMongoDbContextExtensions
    {
        public static void ConfigureClouldItems(
            this IMongoModelBuilder builder,
            Action<MongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new ClouldItemsMongoModelBuilderConfigurationOptions();

            optionsAction?.Invoke(options);
        }
    }
}