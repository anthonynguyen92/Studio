using TN.Studio.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace TN.Studio
{
    [DependsOn(
        typeof(StudioEntityFrameworkCoreTestModule)
        )]
    public class StudioDomainTestModule : AbpModule
    {

    }
}