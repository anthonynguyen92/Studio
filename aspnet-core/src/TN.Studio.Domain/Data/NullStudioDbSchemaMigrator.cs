using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TN.Studio.Data
{
    /* This is used if database provider does't define
     * IStudioDbSchemaMigrator implementation.
     */
    public class NullStudioDbSchemaMigrator : IStudioDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}