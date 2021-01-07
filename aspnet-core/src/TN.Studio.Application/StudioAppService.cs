using System;
using System.Collections.Generic;
using System.Text;
using TN.Studio.Localization;
using Volo.Abp.Application.Services;

namespace TN.Studio
{
    /* Inherit your application services from this class.
     */
    public abstract class StudioAppService : ApplicationService
    {
        protected StudioAppService()
        {
            LocalizationResource = typeof(StudioResource);
            
        }
    }
}
