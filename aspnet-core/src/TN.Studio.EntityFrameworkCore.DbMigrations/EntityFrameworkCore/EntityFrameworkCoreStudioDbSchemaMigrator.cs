using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TN.Studio.Data;
using Volo.Abp.DependencyInjection;

namespace TN.Studio.EntityFrameworkCore
{
    public class EntityFrameworkCoreStudioDbSchemaMigrator
        : IStudioDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreStudioDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the StudioMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<StudioMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}