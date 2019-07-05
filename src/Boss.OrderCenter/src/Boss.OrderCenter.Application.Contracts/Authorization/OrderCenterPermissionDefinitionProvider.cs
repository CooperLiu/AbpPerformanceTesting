using Boss.OrderCenter.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Boss.OrderCenter.Authorization
{
    public class OrderCenterPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            //var moduleGroup = context.AddGroup(OrderCenterPermissions.GroupName, L("Permission:OrderCenter"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<OrderCenterResource>(name);
        }
    }
}