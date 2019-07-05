using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.ClouldItems.MongoDB
{
    [ConnectionStringName("ClouldItems")]
    public class ClouldItemsMongoDbContext : AbpMongoDbContext, IClouldItemsMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = ClouldItemsConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureClouldItems(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}