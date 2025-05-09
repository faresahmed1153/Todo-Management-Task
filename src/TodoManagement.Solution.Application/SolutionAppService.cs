using TodoManagement.Solution.Localization;
using Volo.Abp.Application.Services;

namespace TodoManagement.Solution;

/* Inherit your application services from this class.
 */
public abstract class SolutionAppService : ApplicationService
{
    protected SolutionAppService()
    {
        LocalizationResource = typeof(SolutionResource);
    }
}
