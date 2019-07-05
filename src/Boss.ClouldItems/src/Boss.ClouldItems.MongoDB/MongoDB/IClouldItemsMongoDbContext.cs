using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace Boss.ClouldItems.MongoDB
{
    [ConnectionStringName("ClouldItems")]
    public interface IClouldItemsMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
