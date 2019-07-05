using Boss.ClouldItems.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Boss.ClouldItems.Authorization
{
    public class ClouldItemsPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(ClouldItemsPermissions.GroupName, L("Permission:ClouldItems"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ClouldItemsResource>(name);
        }
    }
}