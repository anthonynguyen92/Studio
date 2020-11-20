using System.Threading.Tasks;

namespace TN.Studio.Data
{
    public interface IStudioDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
