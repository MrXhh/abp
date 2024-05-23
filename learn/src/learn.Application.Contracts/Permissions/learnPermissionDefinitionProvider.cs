using learn.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace learn.Permissions;

public class learnPermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(learnPermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(learnPermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<learnResource>(name);
    }
}
