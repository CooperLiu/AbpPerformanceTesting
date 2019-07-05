using Boss.ClouldItems.Localization;
using Volo.Abp.Application.Services;

namespace Boss.ClouldItems
{
    public abstract class ClouldItemsAppService : ApplicationService
    {
        protected ClouldItemsAppService()
        {
            LocalizationResource = typeof(ClouldItemsResource);
        }
    }
}
