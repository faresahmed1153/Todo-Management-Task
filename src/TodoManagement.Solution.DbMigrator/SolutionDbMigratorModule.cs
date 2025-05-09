using TodoManagement.Solution.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace TodoManagement.Solution.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(SolutionEntityFrameworkCoreModule),
    typeof(SolutionApplicationContractsModule)
)]
public class SolutionDbMigratorModule : AbpModule
{
}
