using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TN.Studio
{
    [Dependency(ReplaceServices = true)]
    public class StudioBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "Studio";
    }
}
