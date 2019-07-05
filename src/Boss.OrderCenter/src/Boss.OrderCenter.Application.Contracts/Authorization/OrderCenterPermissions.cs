using Volo.Abp.Reflection;

namespace Boss.OrderCenter.Authorization
{
    public class OrderCenterPermissions
    {
        public const string GroupName = "OrderCenter";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(OrderCenterPermissions));
        }
    }
}