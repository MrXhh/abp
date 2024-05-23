using learn.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace learn.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class learnController : AbpControllerBase
{
    protected learnController()
    {
        LocalizationResource = typeof(learnResource);
    }
}
