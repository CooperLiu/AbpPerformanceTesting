using Volo.Abp.Reflection;

namespace Boss.ClouldItems.Authorization
{
    public class ClouldItemsPermissions
    {
        public const string GroupName = "ClouldItems";

        public static string[] GetAll()
        {
            return ReflectionHelper.GetPublicConstantsRecursively(typeof(ClouldItemsPermissions));
        }
    }
}