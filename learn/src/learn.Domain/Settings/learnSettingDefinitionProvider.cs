using Volo.Abp.Settings;

namespace learn.Settings;

public class learnSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(learnSettings.MySetting1));
    }
}
