using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace TodoManagement.Solution.Data;

/* This is used if database provider does't define
 * ISolutionDbSchemaMigrator implementation.
 */
public class NullSolutionDbSchemaMigrator : ISolutionDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
