using TodoManagement.Solution.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TodoManagement.Solution.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class SolutionController : AbpControllerBase
{
    protected SolutionController()
    {
        LocalizationResource = typeof(SolutionResource);
    }
}
