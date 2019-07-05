using Boss.ClouldItems.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Boss.ClouldItems
{
    public abstract class ClouldItemsController : AbpController
    {
        protected ClouldItemsController()
        {
            LocalizationResource = typeof(ClouldItemsResource);
        }
    }
}
