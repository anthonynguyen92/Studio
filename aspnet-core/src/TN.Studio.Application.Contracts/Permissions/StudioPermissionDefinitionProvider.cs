using TN.Studio.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TN.Studio.Permissions
{
    public class StudioPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(StudioPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(StudioPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<StudioResource>(name);
        }
    }
}
