using TN.Studio.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace TN.Studio.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class StudioController : AbpController
    {
        protected StudioController()
        {
            LocalizationResource = typeof(StudioResource);
        }
    }
}