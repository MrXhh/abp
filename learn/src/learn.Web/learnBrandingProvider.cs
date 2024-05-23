using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace learn.Web;

[Dependency(ReplaceServices = true)]
public class learnBrandingProvider : DefaultBrandingProvider
{
    public override string AppName => "learn";
}
