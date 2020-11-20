using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace TN.Studio.EntityFrameworkCore
{
    [DependsOn(
        typeof(StudioEntityFrameworkCoreModule)
        )]
    public class StudioEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<StudioMigrationsDbContext>();
        }
    }
}
