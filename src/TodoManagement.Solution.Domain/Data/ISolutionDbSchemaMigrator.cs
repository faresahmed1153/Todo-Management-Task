using System.Threading.Tasks;

namespace TodoManagement.Solution.Data;

public interface ISolutionDbSchemaMigrator
{
    Task MigrateAsync();
}
