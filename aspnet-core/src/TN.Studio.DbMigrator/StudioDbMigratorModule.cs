using TN.Studio.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace TN.Studio.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(StudioEntityFrameworkCoreDbMigrationsModule),
        typeof(StudioApplicationContractsModule)
        )]
    public class StudioDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
