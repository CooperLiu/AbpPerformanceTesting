using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.OrderCenter.MongoDB
{
    [ConnectionStringName("OrderCenter")]
    public interface IOrderCenterMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
