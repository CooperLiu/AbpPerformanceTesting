using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.OrderCenter.MongoDB
{
    [ConnectionStringName("OrderCenter")]
    public class OrderCenterMongoDbContext : AbpMongoDbContext, IOrderCenterMongoDbContext
    {
        public static string CollectionPrefix { get; set; } = OrderCenterConsts.DefaultDbTablePrefix;

        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureOrderCenter(options =>
            {
                options.CollectionPrefix = CollectionPrefix;
            });
        }
    }
}