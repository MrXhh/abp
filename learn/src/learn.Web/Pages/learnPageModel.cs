using learn.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace learn.Web.Pages;

public abstract class learnPageModel : AbpPageModel
{
    protected learnPageModel()
    {
        LocalizationResourceType = typeof(learnResource);
    }
}
