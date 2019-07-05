using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace Boss.ClouldItems.MongoDB
{
    public class ClouldItemsMongoModelBuilderConfigurationOptions : MongoModelBuilderConfigurationOptions
    {
        public ClouldItemsMongoModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = ClouldItemsConsts.DefaultDbTablePrefix)
            : base(tablePrefix)
        {
        }
    }
}