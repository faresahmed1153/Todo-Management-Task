using Microsoft.Extensions.Localization;
using TodoManagement.Solution.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace TodoManagement.Solution;

[Dependency(ReplaceServices = true)]
public class SolutionBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<SolutionResource> _localizer;

    public SolutionBrandingProvider(IStringLocalizer<SolutionResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
