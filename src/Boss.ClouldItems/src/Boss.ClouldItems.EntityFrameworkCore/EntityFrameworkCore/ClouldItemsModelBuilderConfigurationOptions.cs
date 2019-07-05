using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace Boss.ClouldItems.EntityFrameworkCore
{
    public class ClouldItemsModelBuilderConfigurationOptions : ModelBuilderConfigurationOptions
    {
        public ClouldItemsModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = ClouldItemsConsts.DefaultDbTablePrefix,
            [CanBeNull] string schema = ClouldItemsConsts.DefaultDbSchema)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}