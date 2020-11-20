using Volo.Abp.Modularity;

namespace TN.Studio
{
    [DependsOn(
        typeof(StudioApplicationModule),
        typeof(StudioDomainTestModule)
        )]
    public class StudioApplicationTestModule : AbpModule
    {

    }
}