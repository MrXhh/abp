using System;
using System.Collections.Generic;
using System.Text;
using learn.Localization;
using Volo.Abp.Application.Services;

namespace learn;

/* Inherit your application services from this class.
 */
public abstract class learnAppService : ApplicationService
{
    protected learnAppService()
    {
        LocalizationResource = typeof(learnResource);
    }
}
