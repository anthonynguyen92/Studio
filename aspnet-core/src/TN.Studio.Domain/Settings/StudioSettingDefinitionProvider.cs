using Volo.Abp.Settings;

namespace TN.Studio.Settings
{
    public class StudioSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(StudioSettings.MySetting1));
        }
    }
}
